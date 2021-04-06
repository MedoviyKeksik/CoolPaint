using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class EllipseFactory : BaseShapeFactory
    {
        public override BaseShape GetShape()
        {
            return new Ellipse();
        }
    }
}