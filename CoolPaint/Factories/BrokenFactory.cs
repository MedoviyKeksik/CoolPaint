using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class BrokenFactory : BaseShapeFactory
    {
        public override BaseShape GetShape()
        {
            return new Broken();
        }
    }
}