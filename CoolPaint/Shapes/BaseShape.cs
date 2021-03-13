using System.Drawing;

namespace CoolPaint.Shapes
{
    public abstract class BaseShape
    {
        public abstract void Draw(Graphics graphics, Pen pen);
        public abstract void Update(Point newPoint);
        public void AddPoint(Point point)
        {
            return;
        }
    }
}