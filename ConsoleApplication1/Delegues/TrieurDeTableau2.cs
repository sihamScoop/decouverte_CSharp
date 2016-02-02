using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    public class TrieurDeTableau2
    {
 
        ////********!debut:version1
        //private delegate void DelegateTri(int[] tab);
        //private void TriAscendant(int[] tableau)
        //{
        //    Array.Sort(tableau);
        //    foreach (int item in tableau)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("fin tri ascendant");
        //}

        //private void TriDescendant(int[] tableau)
        //{
        //    Array.Sort(tableau);
        //    Array.Reverse(tableau);
        //    foreach (int item in tableau)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine("fin tri descendant");
        //}

        //public void DemoTri(int[] tabtab)
        //{
        //    DelegateTri mydelegate = TriAscendant;
        //    mydelegate += TriDescendant;
        //    mydelegate(tabtab);
        //}
        ////********!fin:version1

        //********!debut:version2
        private void Affichagetri(int[] tableau, Action<int[]> methode)
        {
            //Action<int[]> correspond à la création d'un délégué qui ne renvoie rien et qui prend un tableau d'entier en parametre
            //cela est équivalent à 
            //private delegate void DelegateTri(int[] tab);
            //utilisé dans la version 1

            methode(tableau);
            foreach (int item in tableau)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("fin Affichage");
        }

       

        public void DemoTri(int[] tabtab)
        {
            Affichagetri(tabtab, delegate (int[] tab)
            {
                Array.Sort(tab);
            });

            Console.WriteLine("pause entre les deux");

            Affichagetri(tabtab, delegate (int[] tabi) 
            {
                Array.Sort(tabi);
                Array.Reverse(tabi);
            });
        }
        //********!fin:version2
    }
}
