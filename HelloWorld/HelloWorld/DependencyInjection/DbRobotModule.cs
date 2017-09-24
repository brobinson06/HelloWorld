using Autofac;
using HelloWorld.Interfaces;

namespace HelloWorld.DependencyInjection
{
    public class DbRobotModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<DbRobot>()
                .As<IRobot>();
        }
    }
}
