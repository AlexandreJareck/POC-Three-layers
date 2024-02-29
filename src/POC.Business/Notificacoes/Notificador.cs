using POC.Business.Interfaces;

namespace POC.Business.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            throw new NotImplementedException();
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}