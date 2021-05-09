using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace CoolPaint
{
    internal class PluginNotFoundException : Exception
    {
        public PluginNotFoundException(string typeName, string assemblyName) : base("Figure not found: " + typeName)
        {
        }
    }
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

            if (type == null)
            {
                throw new PluginNotFoundException(typeName, assemblyName);
            }
            return type;
        }
    }
}