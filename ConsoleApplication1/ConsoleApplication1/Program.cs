using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool isValide = false;
            ConsoleKeyInfo saisie ;

            do
            {

                Console.WriteLine("Voulez vous commencer (o/n) ?");
                saisie = Console.ReadKey(true);
                Console.WriteLine(saisie.KeyChar); //permet d'afficher la touche appuyé

                if (saisie.Key != ConsoleKey.N && saisie.Key != ConsoleKey.O)
                {                   
                    Console.WriteLine("saisie incorrecte");
                    isValide = true;
                }
                else
                {
                    isValide = false;
                    //while (saisie.Key != ConsoleKey.N && saisie.Key == ConsoleKey.O)
                    //{
                    while (isValide == false && saisie.Key != ConsoleKey.N)
                        {
                        
                        Console.WriteLine("veuillez donner votre age :");
                            string chaine = Console.ReadLine();

                            if (int.TryParse(chaine, out age))
                            {
                                age = Convert.ToInt32(chaine);
                                if (age > 0)
                                {
                                    isValide = true;
                                    Console.WriteLine("votre age est " + age);
                                }
                                else
                                {
                                    Console.WriteLine("age incorrect, veuillez entrer un entier positif");
                                }

                            }
                            else
                            {
                                Console.WriteLine("age incorrect, veuillez entrer un nombre entier");
                            }

                        }
                }
                
            } while (isValide == true);
            
            Console.WriteLine("à bientôt !!");
            Console.ReadLine();



        }
    }
}
