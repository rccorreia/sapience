using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;

namespace Sapience.Core
{
    public interface ICloudQueueClientFactory
    {
        CloudQueueClient ObterClient();
    }

    public class CloudQueueClientFactory : ICloudQueueClientFactory
    {
        private readonly QueueSettings settings;
        private CloudQueueClient client;

        public CloudQueueClientFactory(QueueSettings settings)
            => this.settings = settings;

        public CloudQueueClient ObterClient()
        {
            if (client != null)
                return client;

            var storageAccount = CloudStorageAccount.Parse(settings.ConnectionString);
            client = storageAccount.CreateCloudQueueClient();
            return client;
        }
    }
}
