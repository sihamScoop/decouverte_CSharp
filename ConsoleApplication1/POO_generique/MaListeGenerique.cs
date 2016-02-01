using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_generique
{
    //création d'un classe générique
    public class MaListeGenerique<T>
    {
        private int capacite;
        private int nombreElmt;
        private T[] tableu;

        public MaListeGenerique()
        {
            capacite = 10;
            nombreElmt = 0;
            tableu = new T[capacite];
        }

        //implémentation de l'ajout dans la liste
        public void Ajouter(T element)
        {
            if (nombreElmt>=capacite)
            {
                capacite *= 2;
                T[] copieTableu = new T[capacite];
                for (int i = 0; i < tableu.Length; i++)
                {
                    copieTableu[i] = tableu[i];
                }
                tableu = copieTableu;
            }
            tableu[nombreElmt] = element; //l'ajout se fais après le dernier, à la position du dernier élement
            nombreElmt++;
        }

        //création de la méthode qui permet de récuperer un élément a un indice donné
        public T ObetnirElement (int indice)
        {
            if (indice<0 || indice>=nombreElmt) //si indice est négatif ou supérieur au nombre d'element, renvoie la valeur par défaut du type générique
            {
                Console.WriteLine("l'indice n'est pas bon");
                return default(T);
            }

            return tableu[indice]; 
        }

    }
}
