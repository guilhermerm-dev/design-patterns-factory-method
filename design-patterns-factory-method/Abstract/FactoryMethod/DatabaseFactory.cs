using System;

namespace design_patterns_factory_method
{
    public abstract class DatabaseFactory
    {
        public abstract DataBaseConnector CreateConnector(string connectionString);

        public static DatabaseFactory Database(DataBase dataBase)
        {

            return dataBase switch
            {
                DataBase.PostgreSql => new PostgreFactory(),
                DataBase.SqlServer => new SqlServerFactory(),
                _ => throw new ApplicationException("Database's type not found !"),
            };
        }
    }
}
