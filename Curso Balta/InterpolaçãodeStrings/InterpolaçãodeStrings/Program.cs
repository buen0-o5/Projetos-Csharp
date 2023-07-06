using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolaçãodeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de interpolação de string
            var price = 10.2;
            var texto = "O preço do produto é ";

            Console.WriteLine(texto + price + " apenas na promoção");
            Console.ReadKey();

            var text = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
            Console.WriteLine(text);
            Console.ReadKey();

            Console.WriteLine($"O preço do produto é {price} tets");
            Console.ReadKey();

            //@ usado para imprimir caracteres especiais
            var te = 28;
            Console.WriteLine($@"\n {te} ");
            Console.ReadKey();
        }
    }
}
