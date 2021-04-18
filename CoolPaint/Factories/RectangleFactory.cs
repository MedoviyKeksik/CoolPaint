using System.Drawing;
using CoolPaint.Shapes;
using Rectangle = CoolPaint.Shapes.Rectangle;

namespace CoolPaint.Factories
{
    public class RectangleFactory : BaseShapeFactory
    {
        public override BaseShape GetShape(Pen pen, Brush brush)
        {
            return new Rectangle(pen, brush);
        }
    }
}