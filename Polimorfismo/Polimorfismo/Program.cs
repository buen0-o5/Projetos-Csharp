using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static List<Veiculo> veiculos = new List<Veiculo>();
        static Random random = new Random();
        static void Main(string[] args)
        {
            //    Veiculo v2 = new Carro(1100, DateTime.Now.Date.AddDays(-600));
            //    Veiculo V3 = new Onibus(6000, DateTime.Now.Date.AddDays(-5800)); //nesse caso nao e possivel reemprementar o metodo 
            //    Onibus V4 = new Onibus(6000, DateTime.Now.Date.AddDays(-5800));

            //    v2.Abastecer(40);
            //    V3.Abastecer(120);

            //    v2.Mover(30);
            //    V3.Mover(100);

            //    v2.Frear();
            //    V3.Frear();
            //    V4.Frear();

            CriarVeiculosAleatorios();
            foreach(var v in veiculos)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(v.Tipo);
                v.Abastecer(random.Next(10, 60));
                v.Mover(random.Next(10, 200));
                v.Frear();
            }
            Console.WriteLine("------------------------");

        }
        static void CriarVeiculosAleatorios()
        {
            for(int i = 0; i<10; i++)
            {
                if(random.Next() % 2 == 0)
                {
                    veiculos.Add(new Carro(random.Next(800, 1400), DateTime.Now.Date.AddDays(-random.Next(30, 3600))));
                }
                else
                {
                    veiculos.Add(new Carro(random.Next(300, 12000), DateTime.Now.Date.AddDays(-random.Next(30, 3600))));
                }
            }
        }
    }
}
