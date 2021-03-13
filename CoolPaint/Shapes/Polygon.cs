using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace CoolPaint.Shapes
{
    public class Polygon : BaseShape
    {
        private Point[] _points;
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawPolygon(pen, _points);
        }

        public override void Update(Point newPoint)
        {
            _points[_points.Length - 1] = newPoint;
        }

        public new void AddPoint(Point point)
        {
            _points.Append(point);
        }
    }
}