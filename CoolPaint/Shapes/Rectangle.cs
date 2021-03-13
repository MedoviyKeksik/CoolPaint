using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Rectangle : BaseShape
    {
        private System.Drawing.Rectangle _rect;

        Rectangle(int x, int y, int width, int height)
        {
            _rect.X = x;
            _rect.Y = y;
            _rect.Width = width;
            _rect.Height = height;
        }
        
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, _rect);
        }

        public override void Update(Point newPoint)
        {
            _rect.Width = newPoint.X - _rect.X;
            _rect.Height = newPoint.Y - _rect.Y;
        }
    }
}