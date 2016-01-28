using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Abstract
{
    public abstract class Animal
    {
        //propriété
        private Coeur coeur;
        //constructeur
        public Animal()
        {
            coeur = new Coeur();
        }
        //méthode abstraite
        public abstract void SeDeplacer();

        //methode non abstraite
        public void Mourir()
        {
            coeur.Stop();
        }
    }
}
