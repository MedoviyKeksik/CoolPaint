using System.Drawing;
using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public class LineFactory : BaseShapeFactory
    {
        public override BaseShape GetShape(Pen pen, Brush brush)
        {
            return new Line(pen, brush);
        }
    }
}