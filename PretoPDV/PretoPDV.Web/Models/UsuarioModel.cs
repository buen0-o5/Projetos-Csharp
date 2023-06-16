using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PretoPDV.Web.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;
            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = "Data Source=DESKTOP-7P7MJSP;Initial Catalog=nemesisdb;Integrated Security=True";

                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                    "select count(*) from usuario where login='{0}' and senha='{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }
            return ret;
        }
    }
}