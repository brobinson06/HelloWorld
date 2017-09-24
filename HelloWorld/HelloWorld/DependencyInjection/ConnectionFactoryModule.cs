using Autofac;
using HelloWorld.Interfaces;

namespace HelloWorld.DependencyInjection
{
    public class ConnectionFactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ConnectionFactory>()
                .As<IConnectionFactory>();
        }
    }
}
