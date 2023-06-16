using System;

namespace ProjetoCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Piity", "Aniceto", new DateTime(2014, 12, 15), "12345678912");
            p1.Peso = 59.5;
            p1.Altura = 1.64;
            p1.MostrarDados();
            p1.Comer(2.5);
            p1.Comer(2000);
            p1.Correr(7,30);
            p1.MostrarDados();
        }
    }
}
