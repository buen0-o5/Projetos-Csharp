using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorDestrutor
{
    class Carro
    {
        public int Portas { get; set; }
        public double Preco { get; set; }
        public string Modelo { get; set; }

        public Carro()
        {
            Console.WriteLine("Um novo objeto carro foi criado");
        }

        public Carro(string modelo) : this()//usado para fazer referencia ao construtor principal
        {
            this.Modelo = modelo;
        }

        public Carro(string modelo,int portas, double preco) : this(modelo)//efeito em casasta pois em construtor referencia outro
        {
            Portas = portas;
            Preco = preco;
        }
    }
}
