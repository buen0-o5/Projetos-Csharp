using System;

namespace ConstrutorDestrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.Modelo = "Fusca";
            c1.Portas = 4;
            c1.Preco = 29990;

            Carro c2 = new Carro();
            c1.Modelo = "Opala";
            c1.Portas = 4;
            c1.Preco = 29990;

            Carro c3 = new Carro("Chevete");
            c1.Portas = 4;
            c1.Preco = 29990;

            Carro c4 = new Carro("Moza", 4, 39990);
        }
    }
}
