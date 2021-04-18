using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CoolPaint.Shapes
{
    [Serializable]
    public class Broken : BaseShape
    {
        private int _index;
        private List<Point> _points;
        private List<Byte> _types;
        public Broken(Pen pen, Brush brush) : base(pen, brush)
        {
            _points = new List<Point>();
            _types = new List<byte>();
            _index = -1;
        }

        public override void SetPostition(Point point)
        {
            _points.Add(point);
            _types.Add((Byte)PathPointType.Line);
            _index++;
        }

        public override void Draw(Graphics graphics)
        {
            if (_index > 0)
            {
                Point[] points = new Point[_index + 1];
                _points.CopyTo(0, points, 0, _index + 1);
                Byte[] types = new Byte[_index + 1];
                _types.CopyTo(0, types, 0, _index + 1);
                types[0] = (byte) PathPointType.Start;
                GraphicsPath path = new GraphicsPath(points, types);
                graphics.DrawPath(_colorData.Pen, path);
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
            _types.Add((Byte)PathPointType.Line);
            _index++;
        }
        public override int DrawMode()
        {
            return 1;
        }

        public override void CutOff()
        {
            if (_index + 1 < _types.Count)
            {
                int tmp = _index + 1;
                _types.RemoveRange(tmp, _types.Count - tmp);
                _points.RemoveRange(tmp, _points.Count - tmp);   
            }
        }

        public override bool CanUndo()
        {
            return _index >= 0;
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
    }
}