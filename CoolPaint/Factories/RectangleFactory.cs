using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class RectangleFactory : BaseShapeFactory
    {
        public override BaseShape GetShape()
        {
            return new Rectangle();
        }
    }
}