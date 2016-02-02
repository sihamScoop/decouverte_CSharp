using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Type_Generique
{
    public class Chainage<T>
    {
        public Chainage<T> precedent { get; set; }
        public Chainage<T> suivant { get; set; }
        public T valeur { get; set; }
       
    }
}
