using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.DependencyInjection
{
    public class HelloWorldContainerCreator : ContainerCreatorBase
    {
        protected DbRobotModule DbRobMod = new DbRobotModule();

        protected DbCommunicatorFactoryModule DbComMod = new DbCommunicatorFactoryModule();

        protected DbCommunicatorModule DbComModule = new DbCommunicatorModule();
        protected ConnectionFactoryModule ConFacModule { get; } = new ConnectionFactoryModule();
        protected LoggerModule LogModule { get; } = new LoggerModule();

    }
}
