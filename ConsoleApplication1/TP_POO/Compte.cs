using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public abstract class Compte
    {

        private string nomProprio;

        protected string _nomProprio
        {
            get { return nomProprio; }
            set { nomProprio = value; }
        }
        

        protected List<Operation> listeOperation;

        private decimal solde;

        public virtual decimal _solde
        {
            get {
                decimal total = 0;
                foreach (Operation oper in listeOperation)
                {
                    if (oper.typeMouvement == Mouvement.Credit)
                    {
                        total += oper.Montant;
                    }
                    else
                    {
                        total -= oper.Montant;
                    }

                }
                return total;
            }
        }

        public Compte()
        {
            this.solde = 0;
        }

        public Compte(string nom)
        {
            this.nomProprio = nom;
            this.solde = 0;
            listeOperation = new List<Mouvement>();
        }

        public void Crediter(double somme)
        {
            this.solde = this.solde + somme;
            Mouvement crediter = new Mouvement(somme, true);
            listeOperation.Add(crediter);
        }
       public void Crediter(double somme, Compte compte)
        {
            this.solde = this.solde + somme;
            compte.solde = compte.solde - somme;
            Mouvement crediter = new Mouvement(somme, true);
            listeOperation.Add(crediter);
        }

        public void Debiter(double somme)
        {
            this.solde = this.solde - somme;
            Mouvement debiter = new Mouvement(somme, false);
            listeOperation.Add(debiter);
        }
        public void Debiter(double somme, Compte compte)
        {
            this.solde = this.solde - somme;
            compte.solde = compte.solde + somme;
            Mouvement debiter = new Mouvement(somme, false);
            listeOperation.Add(debiter);
        }

        public string AffichageListe(List<Mouvement> liste)
        {
            string descrip ="";
            foreach (Mouvement oper in liste)
            {
                descrip += " * "+ oper.ToString();
            }
            return descrip;
        }

        //redéfinition de la méthode ToString()
        public override string ToString()
        {
            string description_compte = "Le compte est la propriété de " + this.nomProprio + " , dont le solde est de : " + this.solde ;
            return description_compte;
        }
    }
}
