using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Meteo
{
    public class Simulateur
    {
        private Temps? ancienTemps;
        private int nombreRepetition;
        private Random rand;
        ////ajout du delegate quine renvoie rien et qui prend un temps en paramètre
        //public delegate void IlfaitBeauDelegate(Temps temps);
        ////ajout d'un événement du type du délégué
        //public event IlfaitBeauDelegate EventquandLeTempsChange;

        //autre version sans déclaration du délégué
        public event Action<Temps> EventquandLeTempsChange;

        //constructeur
        public Simulateur(int nombre)
        {
            rand = new Random();
            ancienTemps = null;
            nombreRepetition = nombre;
        }

        public void Demarrer()
        {
            for (int i = 0; i < nombreRepetition; i++)
            {
                int valeur = rand.Next(0, 100);

                if (valeur < 5)
                {
                    GererTemps(Temps.Soleil);
                }
                else
                {
                    if (valeur < 50)
                    {
                        GererTemps(Temps.Nuage);
                    }
                    else
                    {
                        if (valeur < 90)
                        {
                            GererTemps(Temps.Pluie);
                        }
                        else
                        {
                            GererTemps(Temps.Orage);
                        }
                    }


                }

            }

        }
        //c'est cette méthode qui va lever un événement
        //si le temps change et que quelqu'un  s'est abonné  à l'événement, on léve l'événement
        private void GererTemps(Temps temps)
        {
            if (ancienTemps.HasValue && ancienTemps.Value != temps && EventquandLeTempsChange != null)
            {
                EventquandLeTempsChange(temps);
                
            }
            ancienTemps = temps;
        }
    }
}
