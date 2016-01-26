using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebutPOO
{
    public class Voiture
    {
        //ajout d'une propriété constitué d'une variable membre
        public string couleur;


        //création de la méthode klaxonner
        public void Klaxonner()
        {
            if (!VitesseAutorisee(180))
            {
                Console.WriteLine("pin pon !");
            }
            
        }

        public bool VitesseAutorisee(int vitesse)
        {
            //if (vitesse > 90)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return vitesse <= 90;
        }


        public bool Demarrer()
        {
            if (ClesSurContact())
            {
                DemarrerMoteur();
                return true;
            }
            return false;
        }

        public void SortirDeVoiture()
        {
            if (ClesSurContact())
            {
                PrevenirUtilisteur();
            }
        }

        private bool ClesSurContact()
        {
            //faire une vérification sur la présence de la clé
            return true;
        }

        private void DemarrerMoteur()
        {
            // faire un truc pour demarrer le moteur
        }

        private void PrevenirUtilisteur()
        {
            Console.WriteLine("bip bip ");
        }
    }

}
