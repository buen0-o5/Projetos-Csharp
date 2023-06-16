using Dapper;
using ProjectBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlog.Repositories
{
    public class UserRepository : Repository<Usuario>
    {

        private readonly SqlConnection _connection; //somanete leitura

        public UserRepository(SqlConnection connection)
        :base(connection) //chamando o construtor da classe pai
        {
            _connection = connection;
        }

        public List<Usuario> GetWithRoles()
        {
            var query = @"
            SELECT 
                [Usuario].*,
                [Role].*
            FROM
                [Usuario]
                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [Usuario].[Id]
                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";
            var users = new List<Usuario>();
            var items = _connection.Query<Usuario, Role, Usuario>(query, 
                (user, role) => //funçao
            {
                var usr = users.FirstOrDefault(x => x.Id == user.Id);
                if (usr == null)
                {
                    usr = user;
                    if(role != null)
                         usr.Roles.Add(role);
                   
                    users.Add(usr);
                }
                else
                    usr.Roles.Add(role);
                return user;
            }, splitOn: "Id");

            return users;
        }
    }
}
