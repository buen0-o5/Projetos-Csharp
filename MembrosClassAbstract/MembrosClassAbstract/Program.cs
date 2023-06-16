using System;

namespace MembrosClassAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro(1200);
            Aviao a1 = new Aviao(1200);
            ViajarParaCalifornia(c1);
            ViajarParaCalifornia(a1);

        }
        static void ViajarParaCalifornia(Veiculo v)
        {
            v.Mover(1000);
        }
    }
}
