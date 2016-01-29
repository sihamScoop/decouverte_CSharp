using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class CompteEpargne2:Compte
    {
        private ICalculateur_Benef calculateurBenef;
        public CompteEpargne2(ICalculateur_Benef calculateur)
        {
            this.calculateurBenef = calculateur;
        }

        public override decimal _solde{
            get
            {
                return calculateurBenef.CalculBenefice(base._solde);
            }
        }

        public override void AfficherResumer()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Le compte d'épargne de " + this._nomProprio);
            Console.WriteLine("\t Solde : " + this._solde);
            Console.WriteLine("\t Taux : " + calculateurBenef.Taux);
            Console.WriteLine("\n Les opérations éféctuées sur se compte sont :");
            AffichageOperations(); //appel de la méthode présente dans la classe compte
            Console.WriteLine("*************");
        }
    }
}
