using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal pitty = new Cachorro();
            if (pitty is Cachorro) //verifica se pitty e uma instancia de animal
            {
                (pitty as Cachorro).Farejar();
            }

            Random random = new Random();
            List<IAnimal> animais = new List<IAnimal>();

            for (int i = 0; i < 10; i++)
            {
                int sorteio = random.Next();
                if (sorteio % 2 == 0)
                {
                    animais.Add(new Cachorro());
                }
                else
                {
                    animais.Add(new Passaro());
                }
            }

            foreach (var animal in animais)
            {
                Console.WriteLine("-----------");
                if (animal is ITerrestres)
                {
                    Console.WriteLine("O animal e terrestre");
                }
                if (animal is Ivoador)
                {
                    Console.WriteLine("O animal e voador");
                }

            }

        }
    }
}
