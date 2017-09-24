using Autofac;
using HelloWorld.Interfaces;

namespace HelloWorld.DependencyInjection
{
    public class DbCommunicatorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<DbCommunicator>()
                .As<IDbCommunicator>();
        }
    }
}
