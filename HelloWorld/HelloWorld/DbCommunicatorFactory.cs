using System.Data;
using HelloWorld.Interfaces;

namespace HelloWorld
{
    public class DbCommunicatorFactory : ICommunicatorFactory
    {
        public IDbCommunicator AccessDb(IDbConnection connection)
        {
            return new DbCommunicator(connection);
        }
    }
}
