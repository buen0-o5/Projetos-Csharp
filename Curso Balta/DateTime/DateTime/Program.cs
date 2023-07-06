using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // var date = new DateTime();struct não tem nulo 
            // var date = DateTime.Now; Pegar a data atual
            // Console.WriteLine(date);
            // Console.ReadKey();

            // var date1 = new DateTime(2020,10,12,8,23,14); //sobrecarga de método
            // Console.WriteLine(date1.Date);
            // Console.WriteLine(date1.Day);
            // Console.WriteLine(date1.Year);
            // Console.WriteLine(date1.Hour);
            // Console.WriteLine(date1.Minute);
            // Console.ReadKey();


            //var date = DateTime.Now;
            //var formatada = String.Format("{0:dd/MM/yyyy, hh:mm:ss ff z}",date);
            //Console.WriteLine(formatada);
            //Console.ReadKey();
            // ff: fração de segundo
            // z: timer zone (pais onde a data é pegada)

            //Adicionar valor data 
            //var date = DateTime.Now;
            //var dia = date.Day + 1; //evitar
            //Console.WriteLine(date.AddDays(12));
            //Console.WriteLine(date.AddMonths(1));
            //Console.WriteLine(date.AddYears(1));
            //Console.ReadKey();

            //COMPARAÇÃO DE DADAS
            //var date = DateTime.Now;
            //if(date.Date == DateTime.Now.Date)
            //{
            //    Console.WriteLine("é igual");
            //}
            //Console.ReadKey();

            //TimeZone
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture ;

            Console.WriteLine(DateTime.Now.ToString("D", atual));
            Console.WriteLine(DateTime.Now.ToString("D", en));


            var date1 = DateTime.Now; //hora do servidor
            var date2 = DateTime.UtcNow;//hora universal
            Console.ReadKey();
        }
    }
}
