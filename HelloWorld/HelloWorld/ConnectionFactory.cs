using System;
using System.Data;
using System.Data.OracleClient;
using HelloWorld.Interfaces;

namespace HelloWorld
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly ISQLCommunicationSettings m_settings;

        public ConnectionFactory(ISQLCommunicationSettings settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            m_settings = settings;
        }
        public IDbConnection CreateDbConnection()
        {
            return Create(m_settings.BasicTableConnectionString);
        }

        private static IDbConnection Create(string connectionString)
        {
            return new OracleConnection(connectionString);
        }
    }
}

