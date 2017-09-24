using Autofac;
using Owin;

namespace HelloWorld.Interfaces
{
    public interface IContainerCreator
    {
        ContainerBuilder CreateContainer(IAppBuilder app);
    }
}
