using System;
using System.Collections.Generic;
namespace SistemaEmConsoleProduto
{
    class Program
    {
        public static List<Produto> produto = new List<Produto>();
        static void Main(string[] args)
        {
            //Produto p1 = new Produto();
            //p1.Nome = "Banana";
            //p1.Preco = 3.9;
            //Console.WriteLine($"{p1.Nome} = R$ {p1.Preco:F2}");
            //p1.Comprar(50);
            //Console.WriteLine(p1.ObterTexto());
            string comandoEscolhido = "S";
            do
            {
                //exibiçao do menu
                Console.Clear();
                Console.WriteLine("Escolha uma opçao:");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produtos");
                Console.WriteLine("S - Sair");

                //Leitura da opçao desejada pelo usuario
                Console.WriteLine("Opçao desejada:");
                comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();


                switch (comandoEscolhido)
                {
                    case "1":
                        Console.WriteLine("\nNome do Produto:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("\nPreço do Produto:");
                        string preco = Console.ReadLine();
                        Produto novoProduto = new Produto(nome, Convert.ToDouble(preco));
                        produto.Add(novoProduto);
                        Console.WriteLine("Produto adicionado com sucesso!");
                        break;
                    case "2":
                        if (produto.Count > 0)
                        {
                            Console.WriteLine("\nListagem de Produtos:");
                            foreach (Produto p in produto)
                            {
                                Console.WriteLine(p.ObterTexto());
                            }
                            Console.WriteLine("Precione qualquer tecla para prosseguir...");
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("\n Nao ha produtos cadastrados");
                        break;
                    case "S":
                        Console.WriteLine("\nObrigado por usar o programa");
                        break;
                    default:
                        Console.WriteLine("\nOoçao invalida!Tente novamente");
                        break;
                }
            }while(comandoEscolhido!="S");
            
        }
    }
}
