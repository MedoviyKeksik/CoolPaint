using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Line : BaseShape
    {
        private Point start, end;
        
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, start, end);
        }

        public override void Update(Point newPoint)
        {
            end = newPoint;
        }
    }
}