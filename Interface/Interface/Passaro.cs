using System;

namespace Interface
{
    class Passaro : Ivoador
    {
        public void Comer()
        {
            Console.WriteLine("O passaro esta comendo");
        }

        public void Cor()
        {
            Console.WriteLine("O passaro  e branco");
        }

        public void EmitirSom()
        {
            Console.WriteLine("Piu Piu");
        }

        public void Voar()
        {
            Console.WriteLine("O passaro  esta voando");
        }

        public void Cantar()
        {
            Console.WriteLine("O passara esta cantando");
        }
    }
}
