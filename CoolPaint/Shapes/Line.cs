using System;
using System.Drawing;

namespace CoolPaint.Shapes
{
    [Serializable]
    public class Line : BaseShape
    {
        private bool _visible;
        private Point _start, _finish;

        public Line(Pen pen, Brush brush) : base(pen, brush)
        {
            _start = new Point(0, 0);
            _finish = new Point(0, 0);
            _visible = false;
        }

        public override void SetPostition(Point point)
        {
            _start = point;
            _finish = point;
            _visible = true;
        }

        public override void Draw(Graphics graphics)
        {
            if (_visible)
                graphics.DrawLine(_colorData.Pen, _start, _finish);
        }

        public override void Update(Point newPoint)
        {
            _finish = newPoint;
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