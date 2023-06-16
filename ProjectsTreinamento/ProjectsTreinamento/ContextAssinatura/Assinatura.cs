using ProjectsTreinamento.ConxtetCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContextAssinatura
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; } //data nula, ou seja a assinatura esta ativa
        public bool Inativo => DataFinal  <= DateTime.Now; //verificar se esta inativo se data final for menor que o dia atual
    }
}
