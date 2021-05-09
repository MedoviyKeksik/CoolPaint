using System;
using System.Diagnostics;
using System.Drawing;
using CoolPaint.Factories;
using CoolPaint.Shapes;

namespace Trapezoid
{
    [Factory("Trapezoid")]
    public class TrapezoidFactory : BaseShapeFactory
    {
        public override BaseShape GetShape(Pen pen, Brush brush)
        {
            return new Trapezoid(pen, brush);
        }
    }

    [Serializable]
    public class Trapezoid : Polygon
    {
        public Trapezoid(Pen pen, Brush brush) : base(pen, brush)
        {
        }

        public override int DrawMode()
        {
            if (_index == 3) return 0;
            return 1;
        }

        private bool ClockWise(PointF a, PointF b, PointF c)
        {
            return a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y) < 0;
        }
        private Point Intersect(Line first, Line second)
        {
            float x = (first.b - second.b) / (second.k - first.k);
            float y = first.CountY(x);
            return new Point((int)x, (int)y);
        }
        private Line Parallel(Line line, Point point)
        {
            return new Line(line.k, point.Y - line.k * point.X);
        }

        private Point CalculateFourth(Point point)
        {
            Line baseLine = new Line(_points[0], _points[1]);
            Line parallel = Parallel(baseLine, _points[2]);
            Point result = Intersect(new Line(_points[0], point), parallel);
            if (result.X == int.MinValue)
            {
                result.X = point.X;
                result.Y = (int) parallel.CountY(result.X);
            }
            return result;
        }

        public override void AddPoint(Point point)
        {
            if (_index < 2)
            {
                CutOff();
                _points.Add(point);
                _index++;
            }
            else if (_index == 2)
            {
                CutOff();
                _points.Add(CalculateFourth(point));
                if (ClockWise(_points[0], _points[1], _points[2]) ^ ClockWise(_points[1], _points[2], _points[3]))
                {
                    Point tmp = _points[0];
                    _points[0] = _points[1];
                    _points[1] = tmp;
                }
                _index++;   
            }
        }

        public override void Update(Point newPoint)
        {
            if (_index == 3)
            {
                _points[3] = CalculateFourth(newPoint);
                if (ClockWise(_points[0], _points[1], _points[2]) ^ ClockWise(_points[1], _points[2], _points[3]))
                {
                    Point tmp = _points[0];
                    _points[0] = _points[1];
                    _points[1] = tmp;
                }
            }
            else
            {
                base.Update(newPoint);
            }
        }
    }

    internal struct Line
    {
        public float k, b;
        public Line(float k, float b)
        {
            this.k = k;
            this.b = b;
        }

        public Line(PointF first, PointF second)
        {
            if (second.X - first.X == 0)
            {
                if (second.Y - first.Y > 0) k = float.MaxValue;
                else k = float.MinValue;
            } else k = (second.Y - first.Y) / (second.X - first.X);
            b = first.Y - k * first.X;
        }

        public float CountY(float x)
        {
            return k * x + b;
        }
    }
}
