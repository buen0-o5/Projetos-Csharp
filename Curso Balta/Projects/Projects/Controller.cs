using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
namespace Projects
{
     public static class Controller
    {
      
       
        #region Cronometro
        public static void MenuCron()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("S - segundos");
            Console.WriteLine("M - minutos");
            Console.WriteLine(Resource1.TempoCronometro);
            string data = Console.ReadLine().ToLower();//convert para minuscula
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //Comando que pega o ultimo caractere digitado
            int time = int.Parse(data.Substring(0, data.Length - 1)); //pegar caracteres letras
            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                MenuPrincipal.MenuPrinc();
            PreStart(time * multiplier);

        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);

        }
        public static void Start(int time)
        {

            int currentTime = 0;
            while (currentTime != time)
            {
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1200); // comando para temporizar  a entrada de novos valores no while
            }
            Console.Clear();
            Console.WriteLine("Stopwatcg finalizado... Voltando para o menu");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("Deseja contunar no cronometro?");
            Console.WriteLine("[1]Sim");
            Console.WriteLine("[2]Não, voltar para o menu principal");
            int resul = int.Parse(Console.ReadLine());
            if (resul == 1)
            {
                MenuCron();
            }
            else
            {
                MenuPrincipal.MenuPrinc();
            }



        }
        #endregion

        #region Calculadora
        public static void MenuCalc()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("==============================================");
            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("[1]Soma");
            Console.WriteLine("[2]Subtração");
            Console.WriteLine("[3]Divisão");
            Console.WriteLine("[4]Multiplicação");
            Console.WriteLine("[5] Voltar para o menu principal");
            Console.WriteLine("==============================================");
            Console.WriteLine("Digite a opção desejada:");
            Console.Write("Opção: ");
            short menu = short.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multipicacao();
                    break;
                case 5:
                    MenuPrincipal.MenuPrinc();
                    // System.Environment.Exit(0); fechar a aplicação
                    break;
                default:
                    MenuCalc();
                    break;
            }

        }

        public static void Soma()
        {
            Console.Clear();
            Console.WriteLine("=============Soma=============");
            Console.WriteLine("Digite o primeiro numero:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            resultado = num1 + num2;
            Console.WriteLine("==============================");
            Console.WriteLine("A soma de " + num1 + " mais " + num2 + " é igual a: " + resultado);
            Console.ReadKey();
            MenuCalc();

        }

        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("================Subtracao================");
            Console.WriteLine("Digite o primeiro numero:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            resultado = num1 - num2;
            Console.WriteLine("==============================");
            Console.WriteLine("A subtração de " + num1 + " menos " + num2 + " é igual a: " + resultado);
            Console.ReadKey();
            MenuCalc();
        }

        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("================Divisao================");
            Console.WriteLine("Digite o primeiro numero:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            resultado = num1 / num2;
            Console.WriteLine("==============================");
            Console.WriteLine("A divisão de " + num1 + " dividido por " + num2 + " é igual a: " + resultado);
            Console.ReadKey();
            MenuCalc();
        }

        public static void Multipicacao()
        {
            Console.Clear();
            Console.WriteLine("================Multipicacao================");
            Console.WriteLine("Digite o primeiro numero");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            var num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;
            resultado = num1 * num2;
            Console.WriteLine("==============================");
            Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + resultado);
            Console.ReadKey();
            MenuCalc();
        }

        #endregion
        
        #region Editor de texto
        public static void MenuEdit()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Editor de Texto");
            Console.WriteLine("==============================================");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("[1]Abrir arquivo");
            Console.WriteLine("[2]Criar novo arquivo");
            Console.WriteLine("[3]Voltar para o menu principal");
            Console.WriteLine("==============================================");
            Console.WriteLine("Digite a opção desejada:");
            Console.Write("Opção: ");
            short option = short.Parse(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    AbriArquivo();
                    break;
                case 2:
                    EditarArquivo();
                    break;
                case 3:
                    MenuPrincipal.MenuPrinc();
                    break;
                default:
                    MenuEdit();
                    break;
            }


        }
        public static void AbriArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path)) //abrir o arquivo
            {
                string text = file.ReadToEnd(); //ler o arquivo até o final
                Console.Clear();
                Console.WriteLine($"Caminho:{path}");
                Console.WriteLine("Conteúdo do arquivo:");
                Console.WriteLine("");
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            MenuEdit();
        }
        public static void EditarArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texte abaixo (Esc para sair)");
            Console.WriteLine("-----------------------------");
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //Quebrar a linha após o fim de cada leitura
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape); //comando para sair usando o Escapete
            SalvarArquivo(text);
           
        }
        public static void SalvarArquivo(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");

            var path = Console.ReadLine();
            // StreamReader Abrir arquivo
            // StreamWriter Abrir arquivo para escrita(fluxo de escrita) o parametro passado é a variavel que contem o caminho
            //Um arquivo é um array de bits
           
            using (var file = new StreamWriter(path))//todo objeto que passsar pelo using vai abrir e fechar automaticamente
            {
                file.Write(text);//escrever um arquivo
                //Caminho inicial para salvar C:\Users\BREND
               // Arquivo C:\Users\BREND\OneDrive\Documentos\C#\Treinos\Curso Balta\tes2t.txt

            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!"); //${} interpolação de string
            Console.ReadLine();
            MenuEdit();
        }
        #endregion

        #region Editor HTML
        public static void MenuEdHtml()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Editor HTML");
            Console.WriteLine("==============================================");
            Console.WriteLine("Seleciona uma opção abaixo:");
            Console.WriteLine("[1]Abrir arquivo");
            Console.WriteLine("[2]Criar novo arquivo");
            Console.WriteLine("[3]Voltar para o menu principal");
            Console.WriteLine("==============================================");
            Console.WriteLine("Digite a opção desejada:");
            Console.Write("Opção: ");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:

                    break;
                case 2:
                    EditarHtml();
                    break;
                case 3:
                    MenuPrincipal.MenuPrinc();
                    break;
                default:

                    break;
            }


        }

        public static void EditarHtml()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("                               (Para sair aperte Enter e em seguida Esc)");
            Console.WriteLine("Obs: só é possivel usar a tecla strong em apenas uma palavra sem espaço");
            Console.WriteLine("Digite seu texte abaixo:");
            Console.WriteLine("--------------------------------------------------------------------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Deseja visualizar o arquivos?");
            Console.WriteLine("[1]Sim");
            Console.WriteLine("[2]Não");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    View(file.ToString());
                    break;
                case 2:
                    MenuEdHtml();
                    break;
                default:
                    Start();
                    break;
            }

        }
        public static void View(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo visualização");
            Console.WriteLine("----------------------");
            Replace(text);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");
            Console.ReadKey();
            MenuEdHtml();
        }
        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    

        #endregion

    }
}
