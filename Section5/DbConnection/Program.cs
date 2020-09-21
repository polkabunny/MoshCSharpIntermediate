using DbConnection.Connections;
using System;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("connectionString");
            var oracleConnection = new OracleConnection("connectionString");

            sqlConnection.OpenConnection();
            oracleConnection.OpenConnection();
            sqlConnection.CloseConnection();
            oracleConnection.CloseConnection();
        }
    }
}
