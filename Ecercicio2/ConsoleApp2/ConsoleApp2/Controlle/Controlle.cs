using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    public class Controlle
    {
        String nomePedido = "";
        List<Pedido> lista = new List<Pedido>();
        private List<Pedido> pedidos;
        public List<Pedido> Pedidos
        {
            get
            {
                return pedidos;
            }
        }
        public Controlle()
        {
            pedidos = new List<Pedido>();
        }

        #region Inserir
        public Boolean SalvarPedido(Pedido pedido)
        {
            Boolean resultado = true;
            try
            {
                Pedido p = pedidos.Find(x => x.Id == pedido.Id);
                if (p == null)
                {
                    pedidos.Add(pedido);
                }
                
            }
            catch (Exception Eerror)
            {
                //variável sem uso
                resultado = false;
            }
            return resultado;

        }
        public void Inserir()
        {
            var pedido = new Pedido();
            ValidaId(pedido);
            Console.WriteLine("Nome: ");
            pedido.Nome = Console.ReadLine();
            Console.WriteLine("Descrição do pedido: ");
            pedido.Descricao = Console.ReadLine();
            Console.WriteLine("Informe o lanche: X_Buger[0], X_Salada[1], X_Bacon[2], X_Egg[3], X_Frango[4], X_Tudo[5], Outro[6] ");
            pedido.Lanches = (TipoDeLanches)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a bebida: Coca[0], Peps[1], Fanta[2], Soda[3], Outro[4] ");
            pedido.Bebidas = (TipoDeBebidas)Convert.ToInt32(Console.ReadLine());
            if (SalvarPedido(pedido))
            {
                Console.WriteLine("Pedido inserido!!");
            }
            else
            {
                Console.WriteLine("Pedido não inserido!!");
            }
            Console.ReadKey();
        }

        public Boolean ValidaId(Pedido pedido)
        {
            Console.WriteLine("Insera o Id do Pedido");
            var pedidoId = new Pedido();
            Console.WriteLine("Id: ");
            pedido.Id = Convert.ToInt32(Console.ReadLine());

            Boolean resultado = true;
            try
            {
                Pedido p = pedidos.Find(x => x.Id == pedido.Id);
                if (p != null)
                {
                    resultado = false;
                    Console.Clear();
                    Console.WriteLine("Ops...Id já cadastrado. Por favor faça um novo pedido com um Id diferente!");
                    Thread.Sleep(2700);
                    Console.Clear();
                    ValidaId(pedido);

                }
            }
            catch (Exception Eerror)
            {
                //variável sem uso
                resultado = false;
            }
            return resultado;

        }

        #endregion

        #region Excluir
        public Boolean Excluir(int id)
        {
            Boolean resultado = false;
            Pedido p = pedidos.Find(x => x.Id == id);
            if (p != null)
            {
                resultado = pedidos.Remove(p);
            }
            return resultado;

        }

        public void InforExcluirPedido()
        {
            int id = 0;
            Console.WriteLine("Excluir pedido");
            Console.WriteLine("Informe o id do pedido");
            id = Convert.ToInt32(Console.ReadLine());
            if (Excluir(id))
            {
                Console.WriteLine("Pedido excluido!!");
            }
            else
            {
                Console.WriteLine("Pedido não excluido!!");
            }
            Console.ReadKey();
        }
        #endregion

        #region Alterar
        public Boolean Alterar(Pedido pedido)
        {
            Boolean resultado = false;
            Pedido p = pedidos.Find(x => x.Id == pedido.Id);
            if (p != null)
            {
                p.Nome = pedido.Nome;
                p.Descricao = pedido.Descricao;
                p.Lanches = pedido.Lanches;
                p.Bebidas = pedido.Bebidas;
                resultado = true;
            }
            return resultado;
        }
        public void AlterarPedido()
        {
            Console.WriteLine("Alterar pedido");
            var pedido = new Pedido();
            Console.WriteLine("Id: ");
            pedido.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome: ");
            pedido.Nome = Console.ReadLine();
            Console.WriteLine("Descrição do pedido: ");
            pedido.Descricao = Console.ReadLine();
            Console.WriteLine("Informe o lanche: X_Buger[0], X_Salada[1], X_Bacon[2], X_Egg[3], X_Frango[4], X_Tudo[5], Outro[6] ");
            pedido.Lanches = (TipoDeLanches)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a bebida: Coca[0], Peps[1], Fanta[2], Soda[3], Outro[4] ");
            pedido.Bebidas = (TipoDeBebidas)Convert.ToInt32(Console.ReadLine());
            if (Alterar(pedido))
            {
                Console.WriteLine("Pedido alterado!!");
            }
            else
            {
                Console.WriteLine("Pedido não alterado");
            }
            Console.ReadKey();
        }

        #endregion

        #region Localizar por nome
        public List<Pedido> Localizar(String nome)
        {
            List<Pedido> lp = pedidos.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return lp;
        }
        public void LocalizarNome()
        {
           
            Console.WriteLine("Localizar Pedido");
            Console.WriteLine("Informe o nome do pedido");
            nomePedido = Console.ReadLine();
            lista = Localizar(nomePedido);
            if (lista.Count != 0)
            {
                foreach (var p in lista)
                {
                    Console.WriteLine("Id: " + p.Id);
                    Console.WriteLine("-Nome: " + p.Nome);
                    Console.WriteLine("-Descrição do pedido: " + p.Descricao);
                    Console.WriteLine("-Lanche" + p.Lanches);
                    Console.WriteLine("-Bedidas" + p.Bebidas);
                    Console.WriteLine("=====================================");
                }
            }
            else
            {
                Console.WriteLine("Pedido não cadastrado");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }
        #endregion

        #region Localizar lanche
        public List<Pedido> LocalizarLanche(TipoDeLanches lanches)
        {
            List<Pedido> lp = pedidos.FindAll(x => x.Lanches.Equals(lanches));
            return lp;
        }
        
        public void LocalizarLanche()
        {
            Console.WriteLine("Listar todos os pedidos por lanches");
            Console.WriteLine("Informe o lanche: X_Buger[0], X_Salada[1], X_Bacon[2], X_Egg[3], X_Frango[4], X_Tudo[5], Outro[6] ");
            TipoDeLanches lanches = (TipoDeLanches)Convert.ToInt32(Console.ReadLine());
            lista = LocalizarLanche(lanches);
            if (lista.Count != 0)
            {
                foreach (var p in lista)
                {
                    Console.WriteLine("Id: " + p.Id);
                    Console.WriteLine("-Nome: " + p.Nome);
                    Console.WriteLine("-Descrição do pedido: " + p.Descricao);
                    Console.WriteLine("-Lanche: " + p.Lanches);
                    Console.WriteLine("-Bedidas: " + p.Bebidas);
                    Console.WriteLine("=====================================");
                }
            }
            else
            {
                Console.WriteLine("Lanche não cadastrado");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }
        #endregion

        #region Localizar Bebida
        public List<Pedido> LocalizarBebida(TipoDeBebidas bebidas)
        {
            List<Pedido> lp = pedidos.FindAll(x => x.Bebidas.Equals(bebidas));
            return lp;
        }
        public void LocalizarBebida()
        {
            Console.WriteLine("Listar todos os pedidos por bebidas");
            Console.WriteLine("Informe a bebida: Coca[0], Peps[1], Fanta[2], Soda[3], Outro[4] ");
            TipoDeBebidas bebidas = (TipoDeBebidas)Convert.ToInt32(Console.ReadLine());
            lista = LocalizarBebida(bebidas);
            if (lista.Count != 0)
            {
                foreach (var p in lista)
                {
                    Console.WriteLine("Id: " + p.Id);
                    Console.WriteLine("-Nome: " + p.Nome);
                    Console.WriteLine("-Descrição do pedido: " + p.Descricao);
                    Console.WriteLine("-Lanche: " + p.Lanches);
                    Console.WriteLine("-Bedidas: " + p.Bebidas);
                    Console.WriteLine("=====================================");
                }
            }
            else
            {
                Console.WriteLine("Bebida não cadastrada");
            }
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }


        #endregion

        #region Localizar tudo
        public void LocalizarTudo()
        {
            Console.WriteLine("Listar todos os pedidos");

            foreach (var p in Pedidos)
            {
                Console.WriteLine("Id: " + p.Id);
                Console.WriteLine("-Nome: " + p.Nome);
                Console.WriteLine("-Descrição do pedido: " + p.Descricao);
                Console.WriteLine("-Lanche: " + p.Lanches);
                Console.WriteLine("-Bedidas: " + p.Bebidas);
                Console.WriteLine("=====================================");
            }

            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
        }
        #endregion
        

    }
}
