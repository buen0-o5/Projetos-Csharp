using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeHerança.Classes
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual void AddAumento()
        {
            //aumento de 10%
            double pocentagem = 0.10;
            double aumento = Salario * pocentagem;
            Salario = aumento;
            Console.WriteLine(aumento);
            Console.WriteLine(Salario);
        }
    

        public virtual void  Ficha()
        {
            Console.WriteLine($"{Nome} {Salario}");
        }
    }
}
