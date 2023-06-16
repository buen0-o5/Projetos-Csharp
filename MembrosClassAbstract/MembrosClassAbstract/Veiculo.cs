using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassAbstract
{
    public abstract class Veiculo
    {
        public double Peso { get; set; }
        public Veiculo(double peso)
        {
            this.Peso = peso;
            Console.WriteLine("Um novo obejeto veiculo foi cosntruido");
        }
        ~Veiculo()
        {
            Console.WriteLine("Um novo obejeto veiculo foi destruido");
        }
        public abstract void Mover(double distancia);

    }
}
