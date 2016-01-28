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

        //********!debut:version3
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        //********!fin:version3


        //********!debut:version3
        //********!fin:version3

    }
}
