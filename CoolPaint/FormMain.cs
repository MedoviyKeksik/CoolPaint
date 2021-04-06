using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolPaint.Factories;
using CoolPaint.Shapes;

namespace CoolPaint
{
    public partial class FormMain : Form
    {
        private List<Tuple<BaseShape, Pen, Brush>> _shapes;
        private BaseShapeFactory _currentShapeFactory;
        private BaseShape _lastShape;
        private Pen _lastPen;
        private Brush _lastBrush;
        private int _drawMode;
        public FormMain()
        {
            InitializeComponent();
            
            // Initialize Pen
            _lastPen = new Pen(Color.Black);
            _lastBrush = new SolidBrush(Color.Empty);
            tsbLineColor.BackColor = Color.Black;
            tsbFillColor.BackColor = Color.Empty;
            _shapes = new List<Tuple<BaseShape, Pen, Brush>>();
            _drawMode = 0;
            
            // Initialize buttons with factories
            tsbLine.Tag = new LineFactory();
            tsbBroken.Tag = new BrokenFactory();
            tsbRectangle.Tag = new RectangleFactory();
            tsbEllipse.Tag = new EllipseFactory();
            tsbPolygon.Tag = new PolygonFactory();
        }

        private void PickColor(Object sender, EventArgs e)
        {
            var tsb = sender as ToolStripButton;
            colorDialog.Color = tsb.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                tsb.BackColor = colorDialog.Color;
                if (tsb == tsbLineColor) _lastPen.Color = tsb.BackColor;
                if (tsb == tsbFillColor) ((SolidBrush)_lastBrush).Color = tsb.BackColor;
            }
        }

        private void ToolButtonClick(object sender, EventArgs e)
        {
            _drawMode = 0;
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
            switch (_drawMode)
            {
                case 0:
                {
                    if (_currentShapeFactory != null)
                    {
                        _lastShape = _currentShapeFactory.GetShape();
                        _lastShape.SetPostition(e.Location);
                        _drawMode = _lastShape.DrawMode();
                        _shapes.Add(new Tuple<BaseShape, Pen, Brush>(_lastShape, _lastPen, _lastBrush));
                        _lastPen = (Pen) _lastPen.Clone();
                        _lastBrush = (Brush) _lastBrush.Clone();
                        pbMain.Invalidate();
                    }
                    break;
                }
                case 1:
                {
                    if (_lastShape != null)
                    {
                        _lastShape.AddPoint(e.Location);
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
            foreach (var shape in _shapes)
            {
                shape.Item1.Draw(e.Graphics, shape.Item2, shape.Item3);
            }
        }

        private void pbMain_DoubleClick(object sender, EventArgs e)
        {
            _drawMode = 0;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            _lastPen.Width = Convert.ToSingle(toolStripComboBox1.Text);
        }
    }
}