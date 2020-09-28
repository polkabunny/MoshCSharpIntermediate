using System;
using System.Collections.Generic;
using System.Text;

namespace DbConnection.Commands
{
    public class DbCommand
    {
        private string _instruction;
        private Connections.DbConnection _dbConnection;

        public DbCommand(string instruction, Connections.DbConnection dbConnection)
        {
            _instruction = instruction;
            _dbConnection = dbConnection;
        }
        
        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }
    }
}
