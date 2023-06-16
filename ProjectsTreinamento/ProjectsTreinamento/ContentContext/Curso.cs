using ProjectsTreinamento.ContentContext.Enums;
using ProjectsTreinamento.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContentContext
{
    public class Curso : Conteudo
    {
     
        public Curso(string titulo, string url)
             : base(titulo, url)
        {
            Modulos = new List<Modulo>();
         
        }

     
        public string Tag { get; set; }
        public IList<Modulo> Modulos  { get; set; } //Obs: sempre inicializar pelo construtor
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }
    }
 
  
}
