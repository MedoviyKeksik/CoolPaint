using System.Drawing;

namespace CoolPaint.Shapes
{
    public class Line : BaseShape
    {
        private Point start, finish;
        Line(Point first, Point second)
        {
            start = first;
            finish = second;
        }
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