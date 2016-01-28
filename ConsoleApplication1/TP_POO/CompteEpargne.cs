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


        public CompteEpargne(string nom, double taux):base(nom)
        {
            this.taux_abondement = taux / 100;
        }

        //redéfinition de la méthode ToString()
        public override string ToString()
        {
            string description_compte_courant = "Le compte est la propriété de " + this._nomProprio + " , dont le solde est de : " + this._solde;
            description_compte_courant += "\r sont taux d'abondement est de : " + this._taux_abondement;
            description_compte_courant += "\r la liste des opération est : " + AffichageListe(listeOperation);
            return description_compte_courant;
        }
    }
}
