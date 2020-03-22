namespace Sapience.Core
{
    public class QueueSettings
    {
        public QueueSettings(string connectionString)
            => ConnectionString = connectionString;

        public string ConnectionString { get; }
    }
}
