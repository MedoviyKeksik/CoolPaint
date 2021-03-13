using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Line : BaseShape
    {
        private Point start, finish;
        
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, start, finish);
        }

        public override void Update(Point newPoint)
        {
            finish = newPoint;
        }
    }
}