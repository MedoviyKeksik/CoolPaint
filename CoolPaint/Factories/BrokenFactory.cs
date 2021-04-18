using System.Drawing;
using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class BrokenFactory : BaseShapeFactory
    {
        public override BaseShape GetShape(Pen pen, Brush brush)
        {
            return new Broken(pen, brush);
        }
    }
}