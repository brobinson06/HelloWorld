using Autofac;
using NLog;

namespace HelloWorld.DependencyInjection
{
    public class LoggerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(resolver => LogManager.GetCurrentClassLogger())
                .As<ILogger>();
        }
    }
}
