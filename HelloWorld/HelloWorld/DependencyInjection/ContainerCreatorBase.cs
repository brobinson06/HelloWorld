using System;
using System.Reflection;
using Autofac;
using HelloWorld.Interfaces;
using Owin;
using Module = Autofac.Module;

namespace HelloWorld.DependencyInjection
{
    public class ContainerCreatorBase : IContainerCreator
    {
        public ContainerBuilder CreateContainer(IAppBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            var builder = new ContainerBuilder();
            var thisType = GetType();
            var properties = thisType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var property in properties)
            {
                if (typeof(Module).IsAssignableFrom(property.PropertyType))
                {
                    var module = (Module)property.GetValue(this);
                    builder.RegisterModule(module);
                }
            }

            return builder;
        }
    }
}
