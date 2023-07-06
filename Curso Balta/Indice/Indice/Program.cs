using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indice indica uma posição de um caracte dentro de uma lista
            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));//Busca a posição do Indece
                                                  //método que se extende ao tipo buscado, ex se a variavel
                                                  //declarada é do tipo string o paramentro usado em IndexOf deve ser do mesmo tipo
            Console.WriteLine(texto.LastIndexOf("s"));//ultmo indice de uma letra ou palavra 
            Console.ReadKey();

        }
    }
}
