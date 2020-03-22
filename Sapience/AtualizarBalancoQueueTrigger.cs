using System.Threading.Tasks;
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sapience.Core;

namespace Sapience
{
    public static class AtualizarBalancoQueueTrigger
    {
        [FunctionName("AtualizarBalancoQueueTrigger")]
        public static void Run(
            [QueueTrigger(NomesQueues.Balancos, Connection = "AzureWebJobsStorage")]
            string mensagem,
            ILogger logger)
        {
            try
            {
                var service = ServiceProviderBuilder
                    .Instancia
                    .GetService<IQueueService>();
                var commandHandler = ServiceProviderBuilder
                    .Instancia
                    .GetService<IAtualizarBalancoCommandHandler>();

                var command = service.Ler<AtualizarBalancoCommand>(mensagem);
                commandHandler.Handle(command);

                logger.LogInformation($"Mensagem processada: {mensagem}");
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Erro processando mensagem: {mensagem}");
                throw;
            }
        }
    }
}
