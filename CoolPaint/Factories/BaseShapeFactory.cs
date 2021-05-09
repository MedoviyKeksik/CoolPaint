using System;
using System.Drawing;
using CoolPaint.Shapes;

namespace CoolPaint.Factories
{
    public abstract class BaseShapeFactory
    {
        public abstract BaseShape GetShape(Pen pen, Brush brush);
    }

    public class FactoryAttribute : Attribute
    {
        public string ToolName { get; set; }

        public FactoryAttribute()
        {
        }

        public FactoryAttribute(string toolName)
        {
            ToolName = toolName;
        }
    }
}