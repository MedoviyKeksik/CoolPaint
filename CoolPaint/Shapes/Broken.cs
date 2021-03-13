using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

namespace CoolPaint.Shapes
{
    public class Broken : BaseShape
    {
        private GraphicsPath _graphicsPaths;
        
        Broken()
        
        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawPath(pen, _graphicsPaths);
        }

        public override void Update(Point newPoint)
        {
            _graphicsPaths.PathPoints[_graphicsPaths.PathPoints.Length - 1] = newPoint;
        }
        public new void AddPoint(Point point)
        {   
            
        }
        
    }
}