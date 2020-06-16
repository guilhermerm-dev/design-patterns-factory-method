using System;
using System.Data;

namespace design_patterns_factory_method
{
    class Program
    {
        //private static readonly string connectionString = "User ID=postgres;Password=;Host=localhost;Port=5432;Database=store;Pooling=true;";
        private static readonly string connectionString = "Server=localhost;Database=store;User ID=guilherme;Password=340$Uuxwp7Mcxo7Khy";

        static void Main()
        {
            //var connection = DatabaseFactory.Database(DataBase.PostgreSql)
            //                                .CreateConnector(connectionString)
            //                                .Connect();

            var connection = DatabaseFactory.Database(DataBase.SqlServer)
                                            .CreateConnector(connectionString)
                                            .Connect();

            if (connection.State.Equals(ConnectionState.Open))
            {
                Console.WriteLine("Connection Opened OK");
                Console.WriteLine("Closing Connection....");
                connection.Close();

                if (connection.State.Equals(ConnectionState.Closed))
                    Console.WriteLine("Connection Closed");
            }

            Console.ReadKey();
        }
    }
}
