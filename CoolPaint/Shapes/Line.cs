using System.Drawing;
using System.Windows.Forms;

namespace CoolPaint.Shapes
{
    public class Line : BaseShape
    {
        private Point _start, _finish;

        public Line()
        {
            _start = new Point(0, 0);
            _finish = new Point(0, 0);
        }
        public Line(Point first, Point second)
        {
            _start = first;
            _finish = second;
        }

        public override void SetPostition(Point point)
        {
            _start = point;
            _finish = point;
        }

        public override void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            graphics.DrawLine(pen, _start, _finish);
        }

        public override void Update(Point newPoint)
        {
            _finish = newPoint;
        }
    }
}