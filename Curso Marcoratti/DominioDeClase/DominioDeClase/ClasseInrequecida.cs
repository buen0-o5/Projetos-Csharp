using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioDeClase
{
    public sealed class  ClasseInrequecida
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public ClasseInrequecida(int id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
        public void Upadate(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco); 
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        private void Validar(int id, string nome, string endereco)
        {
            if(id < 0)
                throw new InvalidOperationException("O id tem que ser maior que 0");
           
            if (String.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException("O nome é requerido");

            if (nome.Length < 3)
                throw new InvalidOperationException("O nome deve ter no mínimo 3 caracteres");

            if (endereco.Length > 100)
                throw new InvalidOperationException("O endereço exdeu 100 caracteres");


        }
    }
}
