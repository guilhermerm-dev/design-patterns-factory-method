using System;
using System.Data;
using System.Data.SqlClient;

namespace design_patterns_factory_method.Concrete.Product
{
    public class SqlServerConnector : DataBaseConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override IDbConnection Connect()
        {
            Console.WriteLine("\nConnecting to Postgre Database...");
            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
