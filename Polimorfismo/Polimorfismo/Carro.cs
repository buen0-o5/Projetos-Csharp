using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Carro : Veiculo
    {
        private int capaciade;
        public override int Capacidade 
        { 
            
            get { return capaciade; }
            
            set
            {
                if((value >=2) && (value <= 7))
                {
                    capaciade = value;
                }
                else
                {
                    throw new Exception("O carro pode ter capacidade de 2 a 7 pessoas");
                }
            }
        }

        public int PotenciaCV { get; set; }

        public override void Abastecer(double quantidadeLitro)
        {
            QuantidadeCombustivel += quantidadeLitro;
            Console.WriteLine($"Carro abastecido com {quantidadeLitro} litros de gasolina");
        }

        public override void Mover(double distanciaKm)
        {
            if(QuantidadeCombustivel > (distanciaKm / 10))
            {
                QuantidadeCombustivel -= (distanciaKm / 10);
                Console.WriteLine($"O carro se moveu por {distanciaKm} Kilometro");
            }
            else
            {
                Console.WriteLine("Nao ha combustivel para percorrer a distancia informada");
            }
        }

        public override void Frear()
        {
            Console.WriteLine("Acionando os freios ABS...Parou!");
        }

        public Carro(int pesoKg, DateTime dataFabricacao, int capacidade = 5) : base(pesoKg,dataFabricacao)
        {
            this.Capacidade = capacidade;
        }

    }
}
