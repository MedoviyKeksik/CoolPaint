using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Ellipse : BaseShape
    {
        private int _x, _y;
        private int _width, _height;

        public Ellipse()
        {
        }
        public Ellipse(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public override void SetPostition(Point point)
        {
            _x = point.X;
            _y = point.Y;
        }

        public override void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.FillEllipse(brush, _x, _y, _width, _height);
            graphics.DrawEllipse(pen, _x, _y, _width, _height);
        }

        public override void Update(Point newPoint)
        {
            _width = newPoint.X - _x;
            _height = newPoint.Y - _y;
        }
    }
}