using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using CoolPaint.Factories;
using CoolPaint.Shapes;
using DrawMode = CoolPaint.Shapes.DrawMode;

namespace CoolPaint
{
    public partial class FormMain : Form
    {
        private History _history;
        private BaseShapeFactory _currentShapeFactory;
        private BaseShape _lastShape;
        private Pen _currentPen;
        private Brush _currentBrush;
        private DrawMode _drawMode;
        private string _lastFile;
        private int _toolIndex;
        public FormMain()
        {
            InitializeComponent();
            
            _currentPen = new Pen(Color.Black);
            _currentBrush = new SolidBrush(Color.Empty);
            tsbLineColor.BackColor = Color.Black;
            tsbFillColor.BackColor = Color.Empty;
            _history = new History();
            _drawMode = DrawMode.Undefined;
            saveToolStripMenuItem.Enabled = false;
            
            // Initialize buttons with factories
            tsbLine.Tag = new LineFactory();
            tsbBroken.Tag = new BrokenFactory();
            tsbRectangle.Tag = new RectangleFactory();
            tsbEllipse.Tag = new EllipseFactory();
            tsbPolygon.Tag = new PolygonFactory();
            _toolIndex = 5;
        }

        private void PickColor(Object sender, EventArgs e)
        {
            var tsb = sender as ToolStripButton;
            colorDialog.Color = tsb.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tsb.BackColor = colorDialog.Color;
                if (tsb == tsbLineColor) _currentPen.Color = tsb.BackColor;
                if (tsb == tsbFillColor) ((SolidBrush)_currentBrush).Color = tsb.BackColor;
            }
        }

        private void ToolButtonClick(object sender, EventArgs e)
        {
            _drawMode = DrawMode.Undefined;
            _currentShapeFactory = (BaseShapeFactory) ((ToolStripButton) sender).Tag;
            foreach (var Tool in tsMain.Items)
            {
                if (Tool == sender) continue;
                if (Tool is ToolStripButton && ((ToolStripButton) Tool).Tag != null)
                {
                    ((ToolStripButton) Tool).Checked = false;
                }
            }
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks != 1) return;
            switch (_drawMode)
            {
                case DrawMode.Undefined:
                case DrawMode.DragAndDrop:
                {
                    if (_currentShapeFactory != null)
                    {
                        _lastShape = _currentShapeFactory.GetShape(_currentPen, _currentBrush);
                        _lastShape.SetPostition(e.Location);
                        _drawMode = _lastShape.DrawMode();
                        _history.Add(_lastShape);
                        UpdateUndoRedo();
                        pbMain.Invalidate();
                    }
                    break;
                }
                case DrawMode.ByPoint:
                {
                    if (_lastShape != null)
                    {
                        _lastShape.AddPoint(e.Location);
                        _drawMode = _lastShape.DrawMode();
                        pbMain.Invalidate();
                    }
                    break;
                }
                    
            }
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0 && _lastShape != null)
            {  
                _lastShape.Update(e.Location);
                pbMain.Invalidate();
            }
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in _history.Items)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void pbMain_DoubleClick(object sender, EventArgs e)
        {
            _drawMode = DrawMode.Undefined;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            _currentPen.Width = Convert.ToSingle(toolStripComboBox1.Text);
        }

        private void UpdateUndoRedo()
        {
            undoToolStripMenuItem.Enabled = _history.CanUndo;
            redoToolStripMenuItem.Enabled = _history.CanRedo;
        }
        

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _history.Undo();
            UpdateUndoRedo();
            _lastShape = _history.LastItem;
            pbMain.Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _history.Redo();
            UpdateUndoRedo();
            _lastShape = _history.LastItem;
            _drawMode = DrawMode.Undefined;
            pbMain.Invalidate();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _lastFile = saveFileDialog.FileName;
                saveToolStripMenuItem.Enabled = true;
                BinaryFormatter bf = new BinaryFormatter();
                using (var fs = new FileStream(_lastFile, FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, _history);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var fs = new FileStream(_lastFile, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, _history);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _lastFile = openFileDialog.FileName;
                saveToolStripMenuItem.Enabled = true;
                BinaryFormatter bf = new BinaryFormatter();
                bf.Binder = new CustomBinder();
                using (var fs = new FileStream(_lastFile, FileMode.Open))
                {
                    try
                    {
                        _history = (History) bf.Deserialize(fs);
                    }
                    catch (System.Runtime.Serialization.SerializationException exception)
                    {
                        MessageBox.Show(@"Plugin not loaded: " + exception.Message.Split('"')[1], @"Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            pbMain.Invalidate();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openPluginFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                Assembly plugin = Assembly.LoadFrom(openPluginFileDialog.FileName);
                Type[] types = plugin.GetTypes();
                foreach (var now in types)
                {
                    foreach (var attr in now.GetCustomAttributes())
                    {
                        var factoryAttribute = attr as FactoryAttribute;
                        if (factoryAttribute != null)
                        {
                            ToolStripButton button = new ToolStripButton(factoryAttribute.ToolName);
                            button.Tag = Activator.CreateInstance(now);
                            button.Click += ToolButtonClick;
                            tsMain.Items.Insert(_toolIndex++, button);
                        }    
                    }
                }
            }
        }
    }
}