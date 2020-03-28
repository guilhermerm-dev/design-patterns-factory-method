using System.Data;
namespace design_patterns_factory_method
{
    public abstract class DataBaseConnector
    {
        protected DataBaseConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }
        public abstract IDbConnection Connect();
    }
}
