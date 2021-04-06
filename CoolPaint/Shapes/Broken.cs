using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

namespace CoolPaint.Shapes
{
    public class Broken : BaseShape
    {
        private List<Point> _points;
        private List<Byte> _types;
        public Broken()
        {
            _points = new List<Point>();
            _types = new List<byte>();
        }

        public override void SetPostition(Point point)
        {
            _points.Add(point);
            _types.Add((Byte)PathPointType.Start);
        }

        public override void Draw(Graphics graphics, Pen pen, Brush brush)
        {
            GraphicsPath path = new GraphicsPath(_points.ToArray(), _types.ToArray());
            graphics.DrawPath(pen, path);
        }

        public override void Update(Point newPoint)
        {
            _points[_points.Count - 1] = newPoint;
        }
        public override void AddPoint(Point point)
        {
            _points.Add(point);
            _types.Add((Byte)PathPointType.Line);
        }
        public override int DrawMode()
        {
            return 1;
        }
        
    }
}