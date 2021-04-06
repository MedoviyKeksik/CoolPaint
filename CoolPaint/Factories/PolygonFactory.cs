using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class PolygonFactory : BaseShapeFactory
    {
        public override BaseShape GetShape()
        {
            return new Polygon();
        }
    }
}