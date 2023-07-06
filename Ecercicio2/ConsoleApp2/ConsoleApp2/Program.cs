using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Caixa ===");
            Console.WriteLine("Selecione uma opcao: ");
            Console.WriteLine("[1] Cadastrar um pedido");
            Console.WriteLine("[2] Excluir um pedido");
            Console.WriteLine("[3] Alterar um pedido");
            Console.WriteLine("[4] Localizar um pedido por nome");
            Console.WriteLine("[5] Listar os pedido por Lanche");
            Console.WriteLine("[6] Listar os pedido por Bebida");
            Console.WriteLine("[7] Listar todos os pedido");
            Console.WriteLine("[9] Sair");
            Console.Write("Opcao: ");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            Controlle ListaDePedidos = new Controlle();
            List<Pedido> lista = new List<Pedido>();
            
            

            //Pedidos para teste do sistema
            Pedido pedido = new Pedido(1, "Pitty", "Sem cebola", TipoDeBebidas.Soda, TipoDeLanches.X_Bacon);
            ListaDePedidos.SalvarPedido(pedido);
            pedido = new Pedido(2, "Scooby", "Molho extra", TipoDeBebidas.Coca, TipoDeLanches.X_Tudo);
            ListaDePedidos.SalvarPedido(pedido);

            int op = 0;
            while (op != 9)
            {
                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1: //Inserir
                        ListaDePedidos.Inserir();
                        break;
                    case 2: //Excluir
                        ListaDePedidos.InforExcluirPedido();
                       
                        break;
                    case 3: //Alterar
                        ListaDePedidos.AlterarPedido();

                        break;
                    case 4://Localizar por nome
                        ListaDePedidos.LocalizarNome();
                        break;
                    case 5://Lista de Lanches
                        ListaDePedidos.LocalizarLanche();
                        break;
                    case 6://Lista de Bebidas
                        ListaDePedidos.LocalizarBebida();
                        break;
                    case 7://Lista de pedidos
                        ListaDePedidos.LocalizarTudo();
                        break;
                }
            }
        }
    }
}
