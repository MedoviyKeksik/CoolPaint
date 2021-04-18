using System.Drawing;
using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class EllipseFactory : BaseShapeFactory
    {
        public override BaseShape GetShape(Pen pen, Brush brush)
        {
            return new Ellipse(pen, brush);
        }
    }
}