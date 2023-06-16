using Dapper.Contrib.Extensions;
using ProjectBlog.Models;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ProjectBlog.Repositories
{
    class RoleRepository
    {
        private readonly SqlConnection _connection; //somanete leitura

        public RoleRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Role> Get()
           => _connection.GetAll<Role> ();

        public Role Get(Role id)
            => _connection.Get<Role>(id);

        public void Create(Role role)
            => _connection.Insert<Role>(role);
       

    }
}
