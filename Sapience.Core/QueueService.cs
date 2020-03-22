using System.Threading.Tasks;
using Microsoft.Azure.Storage.Queue;
using Newtonsoft.Json;

namespace Sapience.Core
{
    public interface IQueueService
    {
        T Ler<T>(string mensagem);
        Task EnviarAsync<T>(T obj) where T : MensagemBase;
    }

    public class QueueService : IQueueService
    {
        private readonly ICloudQueueClientFactory factory;

        public QueueService(ICloudQueueClientFactory factory)
            => this.factory = factory;

        public T Ler<T>(string mensagem)
            => JsonConvert.DeserializeObject<T>(mensagem);

        public async Task EnviarAsync<T>(T obj) where T : MensagemBase
        {
            var queueReference = factory
                .ObterClient()
                .GetQueueReference(obj.NomeQueue);

            await queueReference.CreateIfNotExistsAsync();

            var mensagem = JsonConvert.SerializeObject(obj);
            var queueMessage = new CloudQueueMessage(mensagem);
            await queueReference.AddMessageAsync(queueMessage);
        }
    }
}
