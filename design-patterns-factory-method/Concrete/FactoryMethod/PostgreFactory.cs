namespace design_patterns_factory_method
{
    public class PostgreFactory : DatabaseFactory
    {
        public override DataBaseConnector CreateConnector(string connectionString)
        {
            return new PostgreConnector(connectionString);
        }
    }
}
