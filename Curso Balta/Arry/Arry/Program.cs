using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //var meuArray = new int[6] { 1, 2, 3, 4, 5, 6 };
            //meuArray[0] = 12;

            //Console.WriteLine(meuArray[0]);
            //Console.WriteLine(meuArray[1]);
            //Console.WriteLine(meuArray[2]);
            //Console.WriteLine(meuArray[3]);
            //Console.WriteLine(meuArray[4]);
            //Console.WriteLine(meuArray[5]);
            //Console.ReadKey();

            //var meuArray = new int[6] { 1, 2, 3, 4, 5, 6 };
            ////meuArray[0] = 12;

            //for (var item =0; item < meuArray.Length; item++)
            //{
            //    Console.WriteLine(meuArray[item]);
            //}
            //Console.ReadKey();

            ////forech percorre todos os itens

            //foreach(var test in meuArray)
            //{
            //    Console.WriteLine(test);
            //}
            //Console.ReadKey();


            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2579 };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
            }
            Console.ReadKey();



        }
    }
        public struct Funcionario
        {
        public int Id { get; set; }
    }

}
