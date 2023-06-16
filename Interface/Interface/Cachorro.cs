using System;


namespace Interface
{
    class Cachorro : IAnimal , ITerrestres
    {
        public void Cor()
        {
            Console.WriteLine("O cachorro e preto");
        }

        public void Comer()
        {
            Console.WriteLine("O cachorro esta comendo");
        }

        public void EmitirSom()
        {
            Console.WriteLine("Au Au");
        }

        public void Andar()
        {
            Console.WriteLine("O cachorro esta andando");
        }
        public void Farejar()
        {
            Console.WriteLine("O cachorro esta andando");
        }

    }
}
