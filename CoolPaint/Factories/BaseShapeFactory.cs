using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public abstract class BaseShapeFactory
    {
        public abstract BaseShape GetShape();
    }
}