using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_generique
{
    //mise en place d'une interface génerique
    public class Voiture :IComparable<Voiture>
    {
        public string couleur { get; set; }
        public string marque { get; set; }
        public int vitesse { get; set; }
        public override string ToString()
        {
            return "Je suis une voiture";
        }

        public int CompareTo(Voiture obj)
        {
            //plus besoin de cast car l'objet est forcèment de type Voiture
            //Voiture voite = (Voiture)obj;
            return this.vitesse.CompareTo(obj.vitesse);
        }
    }
}
