using ProjectsTreinamento.ConxtetCompartilhado;
using ProjectsTreinamento.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ContentContext
{
    public class ItemCarreira : Base
    {
        
        public ItemCarreira(int ordem, string titulo, string descricao, Curso curso)
        {
            if (curso == null)
                AdicionarNotificacao(new Notificacao("Curso","Curso invalido"));          
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
            
        }
       
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}
