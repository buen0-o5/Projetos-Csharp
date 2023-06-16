using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.NotificacaoContext
{
    public sealed class Notificacao // nao pode ser alterada 
    {
        public Notificacao()
        {

        }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }
        public string Propriedade { get; set; }
        public string Mensagem { get; set; }
    }
}
