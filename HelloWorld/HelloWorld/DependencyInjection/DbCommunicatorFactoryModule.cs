using Autofac;
using HelloWorld.Interfaces;

namespace HelloWorld.DependencyInjection
{
    public class DbCommunicatorFactoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<DbCommunicatorFactory>()
                .As<ICommunicatorFactory>();
        }
    }
}
