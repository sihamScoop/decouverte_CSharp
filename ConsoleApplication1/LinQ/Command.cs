using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Command
    {
        public int identifiant { get; set; }
        public int identifiantClient { get; set; }
        public decimal prix { get; set; }
        public DateTime date { get; set; }
        public int nombreArticles { get; set; }
    }
}
