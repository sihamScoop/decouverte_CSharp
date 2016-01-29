using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class CompteEpargne:Compte
    {
        private double taux_abondement;

        public double _taux_abondement
        {
            get { return taux_abondement; }
            set { taux_abondement = value; }
        }


        public CompteEpargne( double taux)
        {
            this.taux_abondement = taux ;
        }

        public override decimal _solde
        {
            get
            {
                return base._solde * (decimal)(1 + taux_abondement); //appel du solde de l a classe mère
            }
        }

        public override void AfficherResumer()
        {
            Console.WriteLine("*************");
            Console.WriteLine("Le compte d'épargne de " + this._nomProprio);
            Console.WriteLine("\t Solde : "+ this._solde);
            Console.WriteLine("\t Taux : "+ this.taux_abondement);
            Console.WriteLine("\n Les opérations éféctuées sur se compte sont :");
            AffichageOperations(); //appel de la méthode présente dans la classe compte
            Console.WriteLine("*************");
        }
    }
}
