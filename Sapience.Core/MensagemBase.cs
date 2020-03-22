namespace Sapience.Core
{
    public abstract class MensagemBase
    {
        protected MensagemBase(string nomeQueue)
            => NomeQueue = nomeQueue;

        public string NomeQueue { get; }
    }
}
