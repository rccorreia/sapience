namespace Sapience.Core
{
    public interface IAtualizarBalancoCommandHandler
    {
        void Handle(AtualizarBalancoCommand command);
    }

    public class AtualizarBalancoCommandHandler : IAtualizarBalancoCommandHandler
    {
        public void Handle(AtualizarBalancoCommand command) { }
    }
}
