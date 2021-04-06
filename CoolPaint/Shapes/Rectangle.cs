using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Rectangle : BaseShape
    {
        private System.Drawing.Rectangle _rect;

        public Rectangle()
        {
            _rect.X = 0;
            _rect.Y = 0;
            _rect.Width = 0;
            _rect.Height = 0;
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
        public Rectangle(int x, int y, int width, int height)
        {
            _rect.X = x;
            _rect.Y = y;
            _rect.Width = width;
            _rect.Height = height;
        }

        public override void SetPostition(Point point)
        {
            _rect.Location = point;
        }

        public override void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.FillRectangle(brush, GetRect());
            graphics.DrawRectangle(pen, GetRect());
        }

        public override void Update(Point newPoint)
        {
            _rect.Width = newPoint.X - _rect.X;
            _rect.Height = newPoint.Y - _rect.Y;
        }
    }
}