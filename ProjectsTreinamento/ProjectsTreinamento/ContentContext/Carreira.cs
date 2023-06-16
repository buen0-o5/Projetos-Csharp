using ProjectsTreinamento.ContentContext;
using ProjectsTreinamento.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContentContext
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url)
             : base(titulo, url) //passagem por base, como o construtor da classe base tem esses valores no seu construtor e necessario repassar para as classes filhas
        {
            Itens = new List<ItemCarreira>();
 
        }
    
        public IList<ItemCarreira> Itens { get; set; }
        public int TotalCurso => Itens.Count;//Abreviaçao de Get(pois so tem uma linha) Expression Body
                                            //contar os itens
      
    }

    
}
