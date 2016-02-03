using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("utilisation du try catch");
            try
            {
                string chaine = "30";
                int valeur = Convert.ToInt32(chaine);
                Console.WriteLine("message si cela fonctionne correctement");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("message en cas d'erreur");
                //Console.WriteLine("messag d'erreur : " + ex.Message); //fournit le message d'erreur
                //Console.WriteLine("pile d'appel : "+ ex.StackTrace);
                //Console.WriteLine("type de l'exception : " + ex.GetType()); //fournit le type de l'erreur
                //Console.WriteLine("il y a une erreur : " + ex.ToString()); //fournit les infos suffisante pour identifier l'erreur
                Console.WriteLine("erreu de fromat :" + ex); //donne toutes les infos
            }
            Console.WriteLine("utilisation du finally");
            try
            {
                string phrase = Console.ReadLine();
                int nombre = Convert.ToInt32(phrase);
                Console.WriteLine("Vous avez saisie un entier");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("merci d'avoir tapé quelque chose, on peut continuer");
            }

            Console.WriteLine("suite");


            Console.WriteLine("utilisation de levé d'exception ");
            try
            {
                double racien = racinecaree(-6);
            }
            catch (Exception ee)
            {

                Console.WriteLine("Impossible d'effectuer le calcul :" + ee.Message);
            }
            finally{
                Console.WriteLine("suite");
            }

            Console.WriteLine("utilisation d'exception personalisé");
            try
            {
                ChargeProduit("TV HD");
            }
            catch (Exception err)
            {
                Console.WriteLine("erreur " + err.Message );
            }


            Console.ReadLine();
        }

        //application de la levé d'une exception
        public static double racinecaree(double valeur)
        {
            if (valeur<0)
            {
                throw new ArgumentOutOfRangeException("valeur", "la valeur donnée est négative");
               //ne pas oublier de mettre les arguments, c'est la methode exception.message, qui permettera de les afficher
            }

            return Math.Sqrt(valeur);
        }

        public static Produit ChargeProduit(string NameProduct)
        {
            Produit produit = new Produit(-2);
            if (produit._stock <=0)
            {
                throw new PlusStockException(NameProduct); //nous permet de levé l'exception personalisé 
            }
            return produit;
        }

    }
}
