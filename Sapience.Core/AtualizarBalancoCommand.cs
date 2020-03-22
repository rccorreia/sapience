namespace Sapience.Core
{
    public class AtualizarBalancoCommand : MensagemBase
    {
        public string UrlArquivo { get; set; }

        public AtualizarBalancoCommand()
            : base(NomesQueues.Balancos)
        {
        }
    }
}
