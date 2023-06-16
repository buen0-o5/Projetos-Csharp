using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Veiculo
    {
        public int PesoKg { get; set; }
        public DateTime DataFabricacao { get; set; }
        public double QuantidadeCombustivel { get; set; }
        public string Tipo{ get{ return this.GetType().Name; } }
        public abstract int Capacidade { get; set; }

        public abstract void Abastecer(double quantidadeLitro);

        public abstract void Mover(double distanciaKm);

        public virtual void Frear()
        {
            Console.WriteLine("Acionado os freios...Parou!");
        }

        public Veiculo(int pesoKg, DateTime dataFabricacao)
        {
            this.PesoKg = pesoKg;
            this.DataFabricacao = dataFabricacao;
             
        }

    }
}
