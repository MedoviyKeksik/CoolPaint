using System;
using System.Drawing;

namespace CoolPaint.Shapes
{
    [Serializable]
    public class Ellipse : BaseShape
    {
        private bool _visible;
        private int _x, _y;
        private int _width, _height;

        public Ellipse(Pen pen, Brush brush) : base(pen, brush)
        {
            _visible = false;
        }

        public override void SetPostition(Point point)
        {
            _x = point.X;
            _y = point.Y;
            _visible = true;
        }

        public override void Draw(Graphics graphics)
        {
            if (_visible)
            {
                graphics.FillEllipse(_colorData.Brush, _x, _y, _width, _height);
                graphics.DrawEllipse(_colorData.Pen, _x, _y, _width, _height);
            }
        }

        public override void Update(Point newPoint)
        {
            _width = newPoint.X - _x;
            _height = newPoint.Y - _y;
        }

        public override bool CanUndo()
        {
            return _visible;
        }

        public override bool CanRedo()
        {
            return !_visible;
        }

        public override bool Redo()
        {
            if (_visible) return false;
            _visible = true;
            return true;
        }

        public override bool Undo()
        {
            if (!_visible) return false;
            _visible = false;
            return true;
        }
    }
}