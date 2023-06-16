using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeHerança.Classes
{
    public class Assistente : Funcionario
    {
        public int NumeroMatricla { get; set; }
        public override void Ficha()
        {
            Console.WriteLine($"{NumeroMatricla} {Nome} {Salario}");
        }

    }

    
}
