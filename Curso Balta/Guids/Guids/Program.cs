using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //Identificador global unico para gerar numeros
           //Obs: para gerar um novo numero usa-se Guid.NewGuid();, caso usar apenas new Guid sem paramentro será criado apenas zeros
            id.ToString(); //transforma em uma string

            id = new Guid("1a31ab49-1c97-431e-b846-cbab3e0ae51d");
           
            
            // comando para pegar apenas 8 digitos de uma guid  id.ToString().Substring(0, 8);
            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));
            Console.ReadLine();
            //tambem da para fazer uma comparação usando o if


        }
    }
}
