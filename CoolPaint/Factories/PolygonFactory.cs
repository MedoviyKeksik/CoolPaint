using System.Drawing;
using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class PolygonFactory : BaseShapeFactory
    {
        public override BaseShape GetShape(Pen pen, Brush brush)
        {
            return new Polygon(pen, brush);
        }
    }
}