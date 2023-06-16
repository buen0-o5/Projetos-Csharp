using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlog.Models
{
    [Table("[Usuario]")] //metadado (Dapper.Contrib.Extensions) 
    //como o GetAll faz a leitura do banco no plural e necessario informar a descriçao da tabela 
    public class Usuario
    {
        public Usuario()
        {
            Roles = new List<Role>();
        }
        public int Id { get; set; }
        public string Nome  { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio  { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        [Write(false)] // condiçao que serve para ao ler nao incrir 
        public List<Role> Roles { get; set; }
    }
}
