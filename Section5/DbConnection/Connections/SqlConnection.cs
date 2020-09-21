using System;

namespace DbConnection.Connections
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void CloseConnection()
        {
            Console.WriteLine($"{nameof(SqlConnection)}: Opening connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"{nameof(SqlConnection)}: Closing connection");
        }
    }
}
