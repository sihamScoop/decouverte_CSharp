using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class AucunBenef:ICalculateur_Benef
    {

        public decimal CalculBenefice(decimal solde)
        {
            return solde;
        }

        public double Taux
        {
            get { return 0; }
        }
    }
}
