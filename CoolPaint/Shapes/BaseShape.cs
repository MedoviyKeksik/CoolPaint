using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace CoolPaint.Shapes
{

    [Serializable]
    public class ColorData
    {
        private Color _color;
        private int _width;
        private Color _fillColor;
        [NonSerialized]
        public Pen Pen;
        [NonSerialized]
        public Brush Brush;

        public ColorData(Pen pen, Brush brush)
        {
            Pen = (Pen) pen.Clone();
            Brush = (Brush) brush.Clone();
            _color = Pen.Color;
            _width = (int)Pen.Width;
            _fillColor = ((SolidBrush) Brush).Color;
        }
        
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Pen = new Pen(_color, _width);
            Brush = new SolidBrush(_fillColor);
        }
    }
    [Serializable]
    public abstract class BaseShape : IUndovable
    {
        protected ColorData _colorData;
        public BaseShape(Pen pen, Brush brush)
        {
            _colorData = new ColorData(pen, brush);
        }
        public virtual void SetPostition(Point point)
        {
            return;
        }
        public abstract void Draw(Graphics graphics);
        public abstract void Update(Point newPoint);
        public virtual void AddPoint(Point point) { }

        public virtual int DrawMode()
        {
            return 0;
        }

        public virtual void CutOff() { }

        public virtual bool CanUndo()
        {
            return false;
        }

        public virtual bool CanRedo()
        {
            return false;
        }

        public virtual bool Undo()
        {
            return false;
        }

        public virtual bool Redo()
        {
            return false;
        }
    }
}