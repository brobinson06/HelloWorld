using Autofac;
using HelloWorld.Interfaces;

namespace HelloWorld.DependencyInjection
{
    public class ApplicationSettingsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<BasicApplicationSettings>()
                .As<ISQLCommunicationSettings>()
                .InstancePerLifetimeScope();
        }
    }
}
