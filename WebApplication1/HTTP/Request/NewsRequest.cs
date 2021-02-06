using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.HTTP.Request
{

    public class NewsRequest
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string desc { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
