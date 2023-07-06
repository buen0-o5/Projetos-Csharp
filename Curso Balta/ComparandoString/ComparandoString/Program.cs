using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparandoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompareTo compara strings totalmente igual 
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando"));// comando para comparar a string com outro objeto, volta um inteiro
            Console.WriteLine(texto.CompareTo("testando"));//Diferencia letras maiusculas ou minusculas
            Console.ReadKey();

            //Contains
            var texto2 = "Esse texto é um teste";
            Console.WriteLine(texto2.Contains("teste"));//Usado para comparar se um string é totalmente igual ou parte da string, retornando um boolean
            Console.ReadKey();

            //StringComparison.OrdinalIgnoreCase pesquisar!
            // Para ambos os metodos se caso for necesseario fazer uma comparação iguinorando se é maiusculas ou minusculas usa:
            // var text3 = " Esse texto é um teste";
            // Console.WriteLine(text3.Contains("Teste", StringComparison.OrdinalIgnoreCase)); 

            //StartsWith metodo compara o inico do valor da varivael (boolean)
            var teste4 = "Esse texto é um teste";
            Console.WriteLine(teste4.StartsWith("Esse"));
            Console.WriteLine(teste4.StartsWith("esse"));
            Console.ReadKey();

            //EndsWith metodo compara o final do valor da varivael (boolean)
            var teste5 = "Esse texto é um teste";
            Console.WriteLine(teste5.EndsWith("Teste"));
            Console.WriteLine(teste5.EndsWith("teste"));
            Console.ReadKey();

            //Equals para comparar se um objeto é identico ao outro se extende para outros objetos 
            var teste6 = "Esse texto é um teste";
            Console.WriteLine(teste5.Equals("Esse texto é um teste"));
            Console.ReadKey();
        }
    }
}
