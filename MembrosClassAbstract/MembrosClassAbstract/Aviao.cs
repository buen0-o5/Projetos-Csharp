using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassAbstract
{
    public sealed class Aviao : Veiculo //nao pode ser derivado
    {
        public Aviao(double peso) : base(peso)
        {
            Console.WriteLine("Um novo objeto Aviao foi construido");
        }
        ~Aviao()
        {
            Console.WriteLine("Um novo objeto Aviao foi destruido");
        }
        public override void Mover(double distancia)
        {
            Console.WriteLine($"Um novo objeto Aviao se moveu por {distancia} kms");
        }
    }
}
