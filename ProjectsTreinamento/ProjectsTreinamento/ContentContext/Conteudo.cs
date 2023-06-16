using ProjectsTreinamento.ConxtetCompartilhado;
using ProjectsTreinamento.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContentContext
{
    //Nao pode ser instanciada
    public abstract class Conteudo : Base
    {
        public Conteudo(string titulo, string url)
        {
          
            Titulo = titulo;
            Url = url;

        }

        public string Titulo { get; set; }
        public string  Url { get; set; }

    }
}
