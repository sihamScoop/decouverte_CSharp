using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class PlusStockException:Exception
    {
        public  PlusStockException ():base("le produit n'est pas en stock") { }
        //en personalisé
        public PlusStockException(string name) : base("le produit " + name + " n'est plas en stock") { }
    }
}
