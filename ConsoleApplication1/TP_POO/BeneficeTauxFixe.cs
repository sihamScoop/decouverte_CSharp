using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class BeneficeTauxFixe:ICalculateur_Benef
    {
        private double taux;
        public double Taux
        {
            get { return taux; }
        }

        

        public BeneficeTauxFixe(double tauxFixe)
        {
            this.taux = tauxFixe;
        }
        public decimal CalculBenefice(decimal solde)
        {
            return solde * (decimal)(1 + taux);
        }
        
       
        
    }
}
