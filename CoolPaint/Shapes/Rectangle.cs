using System;
using System.Drawing;

namespace CoolPaint.Shapes
{
    [Serializable]
    public class Rectangle : BaseShape
    {
        private System.Drawing.Rectangle _rect;
        private bool _visible;

        public Rectangle(Pen pen, Brush brush) : base(pen, brush)
        {
            _rect.X = 0;
            _rect.Y = 0;
            _rect.Width = 0;
            _rect.Height = 0;
            _visible = false;
        }

        private System.Drawing.Rectangle GetRect()
        {
            System.Drawing.Rectangle res = new System.Drawing.Rectangle(_rect.X, _rect.Y, _rect.Width, _rect.Height);
            if (res.Width < 0)
            {
                res.X += res.Width;
                res.Width = -res.Width;
            }

            if (res.Height < 0)
            {
                res.Y += res.Height;
                res.Height = -res.Height;
            }

            return res;
        }

        public override void SetPostition(Point point)
        {
            _rect.Location = point;
            _visible = true;
        }

        public override void Draw(Graphics graphics)
        {
            if (_visible)
            {
                graphics.FillRectangle(_colorData.Brush, GetRect());
                graphics.DrawRectangle(_colorData.Pen, GetRect());
            }
        }

        public override void Update(Point newPoint)
        {
            _rect.Width = newPoint.X - _rect.X;
            _rect.Height = newPoint.Y - _rect.Y;
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