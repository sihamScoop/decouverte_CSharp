using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class BeneficeAleatoire:ICalculateur_Benef
    {
        private double taux;
        public double _taux
        {
            get { return taux; }
        }

        private Random rand;
        public BeneficeAleatoire()
        {
            rand = new Random();
            this.taux = rand.NextDouble();
        }
        public decimal CalculBenefice(decimal solde)
        {
            return solde * (decimal)(1 + taux);
        }

        
    }
}
