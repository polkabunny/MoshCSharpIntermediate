using System;

namespace DbConnection.Connections
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void CloseConnection()
        {
            Console.WriteLine($"{nameof(OracleConnection)}: Opening connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"{nameof(OracleConnection)}: Closing connection");
        }
    }
}
