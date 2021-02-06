using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.HTTP.Response
{
    public class NewResponse
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string desc { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
