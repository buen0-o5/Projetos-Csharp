using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassAbstract
{
    public sealed class Carro : Veiculo
    {
        public Carro(double peso): base(peso)
        {
            Console.WriteLine("Um novo objeto Carro foi construido");
        }
        ~Carro()
        {
            Console.WriteLine("Um novo objeto Carro foi destruido");
        }

        public override void Mover(double distancia) //implementaçao da classe abstrata
        {
            Console.WriteLine($"Um novo objeto Carro se moveu por {distancia} metros");
        }
    }
}
