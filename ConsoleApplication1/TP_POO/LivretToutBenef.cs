using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class LivretToutBenef : Compte
    {
        private ICalculateur_Benef calculateurBenef;

        public LivretToutBenef(ICalculateur_Benef calculateurBenef)
        {
            this.calculateurBenef = calculateurBenef;
        }

        public override decimal _solde
        {
            get
            {
                return calculateurBenef.CalculBenefice(base._solde);
            }
        }

        public override void AfficherResumer()
        {
            Console.WriteLine("$$$$$$$$$$$");
            Console.WriteLine("Livret toutBénef de " + this._nomProprio);
            Console.WriteLine("\t Solde : " + this._solde);
            Console.WriteLine("\t Taux: "+ calculateurBenef.Taux);
            AffichageOperations(); //utilisation de la méthode static présente dans la classe Outils
            Console.WriteLine("*************");
        }
    }
}
