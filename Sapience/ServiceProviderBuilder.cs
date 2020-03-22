using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sapience.Core;

namespace Sapience
{
    public sealed class ServiceProviderBuilder
    {
        private static readonly IServiceProvider instancia = Build();

        public static IServiceProvider Instancia => instancia;

        static ServiceProviderBuilder() { }

        private ServiceProviderBuilder() { }

        private static IServiceProvider Build()
        {
            var services = new ServiceCollection();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("local.settings.json", true, true)
                .AddEnvironmentVariables()
                .Build();
            services.AddAzureQueue(configuration["AzureWebJobsStorage"]);
            return services.BuildServiceProvider();
        }
    }
}
