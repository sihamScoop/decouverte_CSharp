using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Avancee
{
    public class Voiture :IComparable
    {
        public string couleur { get; set; }
        public string marque { get; set; }
        public int vitesse { get; set; }


        ////********!debut:version2
        ////redéfinition de la méthode equals()
        //public override bool Equals(object obj)
        //{
        //    Voiture voitureTest = obj as Voiture;
        //    if (voitureTest == null) //vérification si on a bien une voiture grace au cast dynamique
        //    {
        //        return false;
        //    }
        //    return this.couleur == voitureTest.couleur && this.marque == voitureTest.marque && this.vitesse == voitureTest.vitesse;
        //    //comparaisons des propriétés
        //}
        ////ajout de la méthode GetHashCode()
        //public override int GetHashCode()
        //{
        //    return this.couleur.GetHashCode() * this.marque.GetHashCode() * this.vitesse.GetHashCode();
        //}
        ////********!fin:version2

        //********!debut:trier une liste ou tableau d'objets
        //redéfinition de la méthode compareTo pour identifier le critère de comparaison
        public int CompareTo(object obj)
        {
            Voiture voite = (Voiture)obj;
            //si on veut faire un tri par ordre decroissant il suffit d'inverser -1 et 1
            //if (this.vitesse < voite.vitesse) //le critère choisi ici est la vitesse
            //{
            //    return -1; 
            //}
            //if (this.vitesse>voite.vitesse)
            //{
            //    return 1;
            //}
            //return 0;
            //autre écriture pour faire le tri par ordre croissant
            return this.vitesse.CompareTo(voite.vitesse);
        }
        //********!fin:trier une liste ou tableau d'objets


        //********!debut:version3
        //********!fin:version3

    }
}
