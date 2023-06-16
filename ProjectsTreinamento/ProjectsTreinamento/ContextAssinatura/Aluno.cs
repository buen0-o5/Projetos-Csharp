using ProjectsTreinamento.ConxtetCompartilhado;
using ProjectsTreinamento.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContextAssinatura
{
    public class Aluno : Base
    {
        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
        public  IList<Assinatura> Assinaturas { get; set; }
        public void CrearAssinatura(Assinatura assinatura)
        {
            if(IsPremium)
            {
               
                AdicionarNotificacao(new Notificacao("Premium", " O aluno ja tem uma assinatura ativa"));
                return;
            }

            Assinaturas.Add(assinatura);
        }
        public bool IsPremium => Assinaturas.Any(x => !x.Inativo); //forma de vericar se o aluno e premium, se


    }
}
