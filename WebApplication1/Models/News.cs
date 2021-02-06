using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class News
    {
        public int id { get; set; }
        public string titel { get; set; }
        public string desc { get; set; }
        public string image { get; set; }
        public string isActive { get; set; }

    }
    public class  NewsList {
        public List<News> data { get; set; }
    }
}
