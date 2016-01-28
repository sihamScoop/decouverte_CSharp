using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class CompteCourant : Compte
    {

        private double decouvert;

        public double _decouvert
        {
            get { return decouvert; }
        }

        public CompteCourant(string nom, double decouvert) : base(nom)
        {
            this.decouvert = decouvert;
        }

        //redéfinition de la méthode ToString()
        public override string ToString()
        {
            string description_compte_courant = "Le compte est la propriété de " + this._nomProprio + " , dont le solde est de : " + this._solde;
            description_compte_courant += "\n sont droit au decouvert est a : " + this._decouvert;
            description_compte_courant += "\n la liste des opération est : "+ AffichageListe(listeOperation);
            return description_compte_courant;
        }
    }
}
