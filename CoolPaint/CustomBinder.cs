using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace CoolPaint
{
    public class CustomBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Type type = null;
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var currentAssembly in assemblies)
            {
                if (assemblyName == currentAssembly.FullName)
                {
                    type = currentAssembly.GetType(typeName);
                    break;
                }
            }

            return type;
        }
    }
}