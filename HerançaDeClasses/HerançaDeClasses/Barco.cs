using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HerançaDeClasses
{
    class Barco : Veiculo
    {
        public int PotenciaHp { get; set; }
        public double TamanhoEmPes 
        { 
            get 
            {
                return this.Comprimento * 3.28;
            } 
        }

        public Barco(double peso, double altura, double largura, double comprimento, int potenciaHp) :
         base(peso, altura, largura, comprimento)
        {
            this.PotenciaHp = potenciaHp;
            Console.WriteLine($"Um objeto do tipo  barco foi criado com densidade {this.Densidade:F2}Kg/m3");

        }
        ~Barco()
        {
            Console.WriteLine("Um objeto do tipo barco foi destruido");

        }

        public void Navegar(double distancia)
        {
            
            double percorrida = 0;
            while (percorrida < distancia)
            {
                Console.WriteLine($"Nosso barco esta a {(distancia - percorrida):F2} metros de distancia do destino");
                percorrida += 20;
                Thread.Sleep(1000);
            }
        }

    }
}
