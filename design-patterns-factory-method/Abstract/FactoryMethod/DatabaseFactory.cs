using System;

namespace design_patterns_factory_method
{
    public abstract class DatabaseFactory
    {
        public abstract DataBaseConnector CreateConnector(string connectionString);

        public static DatabaseFactory Database(DataBase dataBase)
        {
            if (dataBase.Equals(DataBase.PostgreSql))
                return new PostgreFactory();

            throw new ApplicationException("Database's type not found !");
        }
    }
}
