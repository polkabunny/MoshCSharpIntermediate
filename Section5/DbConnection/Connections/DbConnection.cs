using System;

namespace DbConnection.Connections
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new ArgumentNullException("ConnectionString cannot be null or empty");
            }
            Timeout = new TimeSpan();
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
