using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.NotificacaoContext
{
    public abstract class Notificavel //quem executa
    {
        protected Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public List<Notificacao> Notificacoes { get; set; }

        public void AdicionarNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
        public void AdicionarNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
        public bool IsInvalid => Notificacoes.Any();



    }
}
