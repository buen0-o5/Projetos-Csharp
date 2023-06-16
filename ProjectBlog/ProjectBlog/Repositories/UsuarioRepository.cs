using Dapper.Contrib.Extensions;
using ProjectBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlog.Repositories
{
    class UsuarioRepository
    {
        private readonly SqlConnection _connection ; //somanete leitura

        public UsuarioRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Usuario> Get()
            => _connection.GetAll<Usuario>(); //busca todos os campos
        
        public Usuario Get(int Id)
            => _connection.Get<Usuario>(Id); //busca todos os campos
        
        public void Create(Usuario usuario)
        {
            usuario.Id = 0;
            _connection.Insert<Usuario>(usuario); //busca todos os campos
        }
        public void Update(Usuario usuario)
        {
            if(usuario.Id != 0)
            _connection.Update<Usuario>(usuario); //busca todos os campos
        }

        public void Delete(Usuario usuario)
        {
            if (usuario.Id != 0)
                _connection.Delete<Usuario>(usuario); //busca todos os campos
        }
        public void Update(int id)
        {
            if (id != 0)
                return; // se o id for diferente de zero ele sai da funçao
            var user = _connection.Get<Usuario>(id);
                _connection.Delete<Usuario>(user); //busca todos os campos
        }
    }
}
