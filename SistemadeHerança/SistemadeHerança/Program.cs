using SistemadeHerança.Classes;
using System;

namespace SistemadeHerança
{
    class Program 
    {
        static void Main(string[] args)
        {
            var curso = new Assistente();
            curso.NumeroMatricla = 123;
            curso.Nome = "Pitty";
            curso.Salario = 1200;
            curso.AddAumento();
            curso.Ficha();

        }
    }
}
