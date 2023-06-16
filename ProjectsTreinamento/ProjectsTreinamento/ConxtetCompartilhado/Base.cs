using ProjectsTreinamento.NotificacaoContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento.ConxtetCompartilhado
{
    public abstract class Base : Notificavel
    {
        public Base()
        {
            Id = Guid.NewGuid(); // Gerar id automaticamente
            
        }

        public Guid Id { get; set; }
    }
}
