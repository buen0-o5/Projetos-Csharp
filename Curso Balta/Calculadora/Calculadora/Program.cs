using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Soma();
            






        }
        public static void Soma()
        {

            int resultado = 0;
            Console.WriteLine("====Calculadora===");
            Console.WriteLine("Escolha a operação que deseja relizar");
            Console.WriteLine("[1]Soma");
            Console.WriteLine("[2]Subtração");
            Console.WriteLine("[3]Divisão");
            Console.WriteLine("[4]Multiplicação");
            Console.WriteLine("[5]Sair");
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro numero");
            var num1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo numero");
            var num2 = Console.ReadLine();
            switch (menu)
            {
                case 1:
                    Console.WriteLine("===Soma===");
                    resultado = (Convert.ToInt32(num1) + Convert.ToInt32(num2));
                    Console.WriteLine("A soma de " + num1 + " mais " + num2 + " é igual a: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("===Subtração===");
                    resultado = (Convert.ToInt32(num1) - Convert.ToInt32(num2));
                    Console.WriteLine("A subtração de " + num1 + " menos " + num2 + " é igual a: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("===Divisão===");
                    resultado = (Convert.ToInt32(num1) / Convert.ToInt32(num2));
                    Console.WriteLine("A divisão de " + num1 + " dividido por " + num2 + " é igual a: " + resultado);
                    break;
                case 4:
                    Console.WriteLine("===Multiplicação===");
                    resultado = (Convert.ToInt32(num1) * Convert.ToInt32(num2));
                    Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + resultado);
                    break;
            }
            Console.ReadKey();

        }
            
    
       
    
    
    }
}
