using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace CoolPaint.Shapes
{
    public class Polygon : BaseShape
    {
        private List<Point> _points;

        public Polygon()
        {
            _points = new List<Point>();
        }

        public override void SetPostition(Point point)
        {
            _points.Add(point);
        }

        public override void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            if (_points.Count > 1)
            {
                graphics.FillPolygon(brush, _points.ToArray());
                graphics.DrawPolygon(pen, _points.ToArray());
            }
        }

        public override void Update(Point newPoint)
        {
            _points[_points.Count - 1] = newPoint;
        }

        public override void AddPoint(Point point)
        {
            _points.Add(point);
        }

        public override int DrawMode()
        {
            return 1;
        }
    }
}