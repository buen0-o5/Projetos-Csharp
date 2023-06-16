using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Onibus : Veiculo
    {

        private int capaciade;
        public override int Capacidade
        {
            get { return capaciade; }

            set
            {
                if ((value >= 18) && (value <= 60))
                {
                    capaciade = value;
                }
                else
                {
                    throw new Exception("O carro pode ter capacidade de 18 a 60 pessoas");
                }
            }

        }

        public override void Abastecer(double quantidadeLitro)
        {

            QuantidadeCombustivel += quantidadeLitro;
            Console.WriteLine($"Onibus abastecido com {quantidadeLitro} litros de disel");
        }

        public override void Mover(double distanciaKm)
        {

            if (QuantidadeCombustivel > (distanciaKm / 5))
            {
                QuantidadeCombustivel -= (distanciaKm / 5);
                Console.WriteLine($"O onibus se moveu por {distanciaKm} Kilometro");
            }
            else
            {
                Console.WriteLine("Nao ha combustivel para percorrer a distancia informada");
            }
        }
        public new void Frear() //reemprimentar o metodo Frear desconsiderando que ele existe na classe ancestral 
        {
            Console.WriteLine("Acionando os freios a ar ...Parou!");
        }
        public Onibus(int pesoKg, DateTime dataFabricacao, int capacidade = 44) : base(pesoKg, dataFabricacao)
        {
            this.Capacidade = capacidade;
        }
    }
}
