using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlog.Models
{
    [Table("[Post]")]
    class Post
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Post> Posts { get; set; }
    }
}
