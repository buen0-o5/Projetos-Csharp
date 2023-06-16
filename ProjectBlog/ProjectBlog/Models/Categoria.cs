using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlog.Models
{
    [Table("[Categoria]")]
    class Categoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }
    }
}
