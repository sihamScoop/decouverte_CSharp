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

        //ajout d'une propriété accessible en écriture seulement
        private double acceleration;

        public double Acceleration
        {
          
            set { acceleration = value; }
        }

        private string marque;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        private int vitesse;

        public int Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }

        //Constructeur par defaut 
        public Voiture()
        {
            Vitesse = 5;
        }
        //création d'un constructeur
        public Voiture(int velocity)
        {
            Vitesse = velocity;
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

        //ajout de la méthode rouler
        public void Rouler()
        {
            Console.WriteLine("Je roule à " + Vitesse+"km/h");
        }
    }

}
