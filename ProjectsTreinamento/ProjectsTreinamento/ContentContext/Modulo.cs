using ProjectsTreinamento.ConxtetCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContentContext
{
   public class Modulo : Base
    {
      
        public Modulo()
        {
           Classes = new List<Classe>();
        }
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public IList<Classe> Classes { get; set; }
        
    }
}
