using System;
using design_patterns_factory_method.Concrete.Product;

namespace design_patterns_factory_method
{
    public class SqlServerFactory : DatabaseFactory
    {
        public override DataBaseConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
