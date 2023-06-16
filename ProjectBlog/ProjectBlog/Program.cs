using Dapper.Contrib.Extensions;
using ProjectBlog.Models;
using ProjectBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlog
{
    class Program
    {



        static void Main(string[] args)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            // ReadUsers(connection);
            ReadUserWithRoles(connection);
            //ReadRoles(connection);
            //ReadTag(connection);
            connection.Close();
            Console.ReadLine();

        }

       private const string connectionString = " Data Source=DESKTOP-7P7MJSP;Initial Catalog=Blog; Integrated Security = True; ";

        public static void ReadUserWithRoles(SqlConnection connection)
        {
            //Leitura e conexao
            var repository = new UserRepository(connection); //instanciando a classe repositorio para passagem da classe
            var items = repository.GetWithRoles();  //busca todos os campos
            foreach (var item in items)
            {
                Console.WriteLine(item.Nome);
                foreach(var role in item.Roles)
                {
                    Console.WriteLine($"- {role.Nome}");
                }
            }
        }
        public static void CreatUsuario(SqlConnection connection)
        {
            var repository = new Repository<Usuario>(connection);
            var create = new Usuario
            {
                Bio = "Equipe pitty.br",
                Email = "PittyPretinha@Outilok",
                Image = "Https://..",
                Nome = "P",
                PasswordHash = "Has",
                Slug = "equipe Pitt"
            };
            connection.Insert<Usuario>(create);
        }

        public static void UpdateUsuario(SqlConnection connection)
        {
            var repository = new Repository<Usuario>(connection);
            var update = new Usuario
            {
                Id = 3,
                Bio = "Equipe",
                Email = "Equipe@Outilokk",
                Image = "Https://...",
                Nome = "EQ",
                PasswordHash = "Hash",
                Slug = "equipe de suporte"
            };
            connection.Update<Usuario>(update);
        }

        public static void DeleteUsuario(SqlConnection connection)
        {
            var repository = new Repository<Usuario>(connection);
            var user = connection.Get<Usuario>(3);
            connection.Delete<Usuario>(user);
        }








        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();  //busca todos os campos

            foreach (var item in items)
            {
                Console.WriteLine(item.Nome);
            }
        
        }
        public static void ReadTag(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();  //busca todos os campos

            foreach (var item in items)
            {
                Console.WriteLine(item.Nome);
            }

        }

       

        
    }
}
