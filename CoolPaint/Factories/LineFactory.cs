using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class LineFactory : BaseShapeFactory
    {
        public override BaseShape GetShape()
        {
            return new Line();
        }
    }
}