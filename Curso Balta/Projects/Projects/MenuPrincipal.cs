using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class MenuPrincipal
    {
        #region Menu
        public static void MenuPrinc()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            Console.ReadKey();

        }

        public static void DrawScreen()
        {
            Linhas();
            Colounas();
            Linhas();

        }

        public static void Colounas()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 60; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");

            }

        }
        public static void Linhas()
        {
            Console.Write("+");
            for (int i = 0; i <= 60; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("=================Seja bem vindo!=================");
            Console.SetCursorPosition(3, 3);
            Console.Write(" Esolha a opção que deseja realizar");
            Console.SetCursorPosition(3, 4);
            Console.Write(" [1]Calculadora");
            Console.SetCursorPosition(3, 5);
            Console.Write(" [2]Cronometro");
            Console.SetCursorPosition(3, 6);
            Console.Write(" [3]Editor de texto");
            Console.SetCursorPosition(3, 7);
            Console.Write(" [4]Editor HTML");
            Console.SetCursorPosition(3, 8);
            Console.Write(" [5]Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("-----------------------------");
            Console.SetCursorPosition(3, 10);
            Console.Write("Digite a opção desejada:");
            Console.SetCursorPosition(4, 11);
            Console.Write("Opção: ");
            var menu = short.Parse(Console.ReadLine());
            HandleMenuOption(menu);


        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Controller.MenuCalc();
                    break;
                case 2:
                    Controller.MenuCron();
                    break;
                case 3:
                    Controller.MenuEdit();
                    break;
                case 4:
                    Controller.MenuEdHtml();
                    break;
                case 5:
                    System.Environment.Exit(0); //sair
                    break;
                default:
                    MenuPrinc();
                    break;
            }
        }
        #endregion
    }
}
