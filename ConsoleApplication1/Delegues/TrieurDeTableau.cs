using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    public class TrieurDeTableau
    {
        //création d'un délégué privé de l classe TrieurDeTableau qui permettra de pointer vers des méthodes "void" et 
        //qui acceptent un tableau d'entier en paramètres
        private delegate void DelegateTri(int[] tab);

        private void TriAscendant(int[] tableau)
        {
            Array.Sort(tableau);
        }

        private void TriDescendant(int[] tableau)
        {
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }

        ////********!debut:version1
        ////création de la méthode qui permet d'utiliser le delégué
        //public void DemoTri(int[] tabtab)
        //{
        //    //création du délégué
        //    DelegateTri delegue;
        //    //on fait pointer cette variable(le delegué) vers la méthode TriAscendant
        //    delegue = TriAscendant;
        //    //attribution du paramètre
        //    delegue(tabtab);
        //    //affichage des données
        //    foreach (int item in tabtab)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.WriteLine();
        //    delegue = TriDescendant;
        //    delegue(tabtab);
        //    foreach (int item in tabtab)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}
        ////********!fin:version1

        ////********!debut:version2
        ////amélioration de la méthode précédents(version1) en inserant la méthode AffichageTri(tabtab, delegue);
        //public void DemoTri(int[] tabtab)
        //{           
        //    AffichageTri(tabtab, TriAscendant);
        //    Console.WriteLine();
        //    AffichageTri(tabtab, TriDescendant);
        //}
        //private void AffichageTri(int[] tab, DelegateTri monDelegate)
        //{
        //    monDelegate(tab);
        //    foreach (int item in tab)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        ////********!fin:version2

        //********!debut:version3
        //insertion des méthode directement en utilisant un delegate et des méthodes anonymes
        //et donc plus besoin des méthodes TriAscendant() et TriDescendant()
        private void AffichageTri(int[] tab, DelegateTri monDelegate)
        {
            monDelegate(tab);
            foreach (int item in tab)
            {
                Console.WriteLine(item);
            }
        }

        public void DemoTri(int[] tabtab)
        {
            AffichageTri(tabtab, delegate (int[] theTableau)
                                    {
                                        Array.Sort(theTableau);
                                    }
                                );
            Console.WriteLine();
            AffichageTri(tabtab, delegate (int[] autreTableu)
                                    {
                                        Array.Sort(autreTableu);
                                        Array.Reverse(autreTableu);
                                    }
                                );
        }
        //********!fin:version3
    }
}
