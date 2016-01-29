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

        public string _nomProprio
        {
            get { return nomProprio; }
            set { nomProprio = value; }
        }
        

        protected List<Operation> listeOperation;

        

        public virtual decimal _solde
        {
            get {
                decimal total = 0;
                foreach (Operation oper in listeOperation)
                {
                    if (oper.typeMouvement == Mouvement.Credit)
                    {
                        total += oper._montant;
                    }
                    else
                    {
                        total -= oper._montant;
                    }

                }
                return total;
            }
        }

       

        public Compte()
        {
            
            listeOperation = new List<Operation>();
        }

        public void Crediter(decimal somme)
        {
            EnregistrementOperation(Mouvement.Credit, somme);
        }
       public void Crediter(decimal somme, Compte compte)
        {
            Crediter(somme);
            compte.Debiter(somme);
        }

        public void Debiter(decimal somme)
        {
            EnregistrementOperation(Mouvement.Debit, somme);
        }
        public void Debiter(decimal somme, Compte compte)
        {
            Debiter(somme);
            compte.Crediter(somme);
        }

        protected void AffichageOperations()
        {
            foreach (Operation oper in listeOperation)
            {
                if (oper.typeMouvement == Mouvement.Credit)
                {
                    Console.Write("\t + ");
                }
                else
                {
                    Console.Write("\t - ");
                }
                Console.WriteLine(oper._montant);
            }
        }

        private void EnregistrementOperation(Mouvement typeMouv, decimal montant)
        {
            Operation oper = new Operation { _montant = montant, typeMouvement = typeMouv };
            listeOperation.Add(oper);

        }

        public abstract void AfficherResumer();
    }
}
