using System;
using System.Collections.Generic;
using System.Drawing;

namespace CoolPaint.Shapes
{
    [Serializable]
    public class Polygon : BaseShape
    {
        protected int _index;
        protected List<Point> _points;

        public Polygon(Pen pen, Brush brush) : base(pen, brush)
        {
            _points = new List<Point>();
            _index = -1;
        }

        public override void SetPostition(Point point)
        {
            _points.Add(point);
            _index++;
        }

        public override void Draw(Graphics graphics)
        {
            if (_index > 0)
            {
                Point[] tmp = new Point[_index + 1];
                _points.CopyTo(0, tmp, 0, _index + 1);
                graphics.FillPolygon(_colorData.Brush, tmp);
                graphics.DrawPolygon(_colorData.Pen, tmp);
            }
        }

        public override void Update(Point newPoint)
        {
            _points[_points.Count - 1] = newPoint;
        }

        public override void AddPoint(Point point)
        {
            CutOff();
            _points.Add(point);
            _index++;
        }

        public override DrawMode DrawMode()
        {
            return Shapes.DrawMode.ByPoint;
        }

        public override bool CanUndo()
        {
            return _index > -1;
        }

        public override bool CanRedo()
        {
            return _index + 1 < _points.Count;
        }

        public override bool Undo()
        {
            if (_index == -1) return false;
            _index--;
            return true;
        }

        public override bool Redo()
        {
            if (_index + 1 == _points.Count) return false;
            _index++;
            return true;
        }

        public override void CutOff()
        {
            if (_index + 1 < _points.Count)
            {
                int tmp = _index + 1;
                _points.RemoveRange(tmp, _points.Count - tmp);   
            }
        }
    }
}