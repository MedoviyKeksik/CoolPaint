using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Ellipse : BaseShape
    {
        private int x, y;
        private int width, height;

        Ellipse(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        
        public override void Draw(Graphics graphics, Pen pen)
        {   
            graphics.DrawEllipse(pen, x, y, width, height);
        }

        public override void Update(Point newPoint)
        {
            width = newPoint.X - x;
            height = newPoint.Y - y;
        }
    }
}