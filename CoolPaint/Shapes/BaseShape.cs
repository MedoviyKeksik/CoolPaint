using System.Drawing;

namespace CoolPaint.Shapes
{
    public abstract class BaseShape
    {
        public virtual void SetPostition(Point point)
        {
            return;
        }
        public abstract void Draw(Graphics graphics, Pen pen, Brush brush);
        public abstract void Update(Point newPoint);
        public virtual void AddPoint(Point point)
        {
            return;
        }

        public virtual int DrawMode()
        {
            return 0;
        }
    }
}