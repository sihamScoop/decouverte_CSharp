using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    public class ChangementPrixEventArgs : EventArgs
    {
        public decimal Prix { get; set; }
    }
}
