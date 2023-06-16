using System;

namespace HerançaDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao(3200, 4, 16, 12, 12);
            //a1.Voar(1000);
            Barco b1 = new Barco(1200, 2.5, 4, 12, 800);
            b1.Navegar(200);
        }
    }
}
