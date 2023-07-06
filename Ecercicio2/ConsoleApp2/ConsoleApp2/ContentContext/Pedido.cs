using System;
using System.Collections.Generic;

namespace ConsoleApp2
{


    public enum TipoDeLanches { X_Buger, X_Salada, X_Bacon, X_Egg, X_Frango, X_Tudo, Outro };
    public enum TipoDeBebidas { Coca, Peps, Fanta, Soda, Outro }
    public class Pedido
    {
        
        public Pedido(int id, string nome, string descricao, TipoDeBebidas bebidas, TipoDeLanches lanches)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Bebidas = bebidas;
            this.Lanches = lanches;
        }

        public Pedido()
        {
            this.Id = 0;
            this.Nome = "";
            this.Descricao = "";
            this.Bebidas = TipoDeBebidas.Outro;
            this.Lanches = TipoDeLanches.Outro;
        }
        

        private int id;
        public int Id
        {
            get { return id; }

            set
            {
                if (value >= 0) id = value;
                else
                    throw new Exception("Esse campo aceita apenas numeros positivos");

            }

        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }

        }

        private String descricao;



        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }


        }
        public TipoDeBebidas Bebidas { get; set; }
        public TipoDeLanches Lanches { get; set; }




    }
}
