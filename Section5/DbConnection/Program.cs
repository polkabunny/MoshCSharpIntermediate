using DbConnection.Commands;
using DbConnection.Connections;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("connectionString");
            var oracleConnection = new OracleConnection("connectionString");

            var sqlCommand = new DbCommand("SELECT * FROM SqlDb", sqlConnection);
            var oracleCommand = new DbCommand("SELECT * FROM OracleDb", oracleConnection);

            sqlCommand.Execute();
            oracleCommand.Execute();
        }
    }
}
