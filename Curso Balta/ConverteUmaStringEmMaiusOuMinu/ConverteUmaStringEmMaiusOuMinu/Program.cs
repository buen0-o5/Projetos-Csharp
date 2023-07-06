using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteUmaStringEmMaiusOuMinu
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = " Esse texto é um teste ";
            Console.WriteLine(texto.ToUpper());//maiuscula
            Console.WriteLine(texto.ToLower());//minuscula
            Console.ReadKey();

            //inserir
            Console.WriteLine(texto.Insert(5, " AQUI "));//metodo para inserir novo objeto, de incio é informado o
                                                       //indice para informar a posição que será atribuido o novo valor
            Console.ReadKey();


            //remove
            Console.WriteLine(texto.Remove(5, 5));//metodo para remover um objeto, de incio é informado o
                                                         //inicio e fim
            Console.ReadKey();

            // propriedade Length

            Console.WriteLine(texto.Length);//usado para ver a quantidade de caracteres
            Console.ReadKey();

            //replace
            Console.WriteLine(texto.Replace("Esse", "Isto"));//pede o caracte antigo e um novo
            Console.ReadKey();

            //Split trasnforma o testo em uma lista
            //var divisao = texto.Split(" ");

            //Substring pegar 
            var resultado = texto.Substring(5, 5);
            Console.ReadKey();

            //Trim tirar os espaços
            Console.WriteLine(texto.Trim());
            Console.ReadKey();


            //Builde contrutor
            var text = new StringBuilder();
            text.Append("oi"); //anexar um testo
            text.Append("oi");
            text.Append("oi");
            Console.WriteLine(text);
            Console.ReadKey();
            //em caso especificos é necessario conveter para string e para isso usa-se o .tostring
        }
    }
}
