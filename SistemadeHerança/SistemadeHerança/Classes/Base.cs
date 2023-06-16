using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeHerança.Classes
{
        public interface IBase
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public  void AddAumento()
        {
        }
        public  void Ficha()
        {
        }

    }
}
