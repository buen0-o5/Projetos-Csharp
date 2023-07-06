using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decimo(m) mais indicado para lidar com moedas
            //Formatação de moedas
            //decimal valor = 10.25m;
            //Console.WriteLine(valor.ToString(
            //formatadores pesquisar sobre
            // "G",
            //"C", // padrao de moeda
            //CultureInfo.CreateSpecificCulture("pt-BR")));
            //Console.ReadKey();


            //Arredondamento
            decimal valor = 10.25m;
            Console.WriteLine(Math.Round(valor)); //arredondar
            Console.WriteLine(Math.Ceiling(valor));//arredondar para cima
            Console.WriteLine(Math.Round(valor)));//arredondar para baixo

            Console.ReadKey();
        }
    }
}
