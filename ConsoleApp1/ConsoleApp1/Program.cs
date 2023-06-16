using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            int b = Convert.ToInt32(Console.ReadLine());

            

            if(a < b) 
            {
                var soma = a + b;
                for (var i = 1; i <= soma; i++)
                {
               var resultado = i % 2 == 1 ? "Impar" : "par";
                Console.WriteLine($"O valor {i} e {resultado}");
                }
            } else if(a > b)
            {
                var soma = a + b;
                int multiplo;
                for (var i = 1; i <= soma; i++)
                {
                    if(soma% 3 == 0)
                    {
                        multiplo = soma;
                        Console.WriteLine($"o valor {i} nao possui mulplos de 3");
                    }
                    else
                    {
                        multiplo = (soma - (soma % 3)) + 3;
                        Console.WriteLine($" {i} {multiplo}");
                    }
                }
            } 




            Console.ReadKey();



        }
    }
}
