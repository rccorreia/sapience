using Microsoft.Extensions.DependencyInjection;

namespace Sapience.Core
{
    public static class ServiceCollectionExtensions
    {
        public static ServiceCollection AddAzureQueue(this ServiceCollection services,
            string connectionString)
        {
            services.AddSingleton(new QueueSettings(connectionString));
            services.AddSingleton<ICloudQueueClientFactory, CloudQueueClientFactory>();
            services.AddTransient<IQueueService, QueueService>();
            return services;
        }
    }
}
