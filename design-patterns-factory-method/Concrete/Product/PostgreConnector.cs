using System;
using System.Data;
using Npgsql;

namespace design_patterns_factory_method
{
    public class PostgreConnector : DataBaseConnector
    {
        public PostgreConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override IDbConnection Connect()
        {
            Console.WriteLine("\nConnecting to Postgre Database...");
            var connection = new NpgsqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
