using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_meteo_moi
{
    public enum LesTemps { soleil, nuage, pluie, orage }
    public class Simulateur
    {
        private int nombrerepetition;
        private Random random;
        private LesTemps? ancienTemps;

        public delegate void mondelege(LesTemps temps);
        public event mondelege eventChangementTemp;

        public Simulateur(int nombre)
        {
            nombrerepetition = nombre;
            random = new Random();
            ancienTemps = null;
        }

        public void DemarrerSimulateur()
        {
            for (int i = 0; i < nombrerepetition; i++)
            {
                int value = random.Next(0, 100);

                if (value < 5)
                {
                    //il ya soleil
                    ChangeTemps(LesTemps.soleil);
                }
                else
                {
                    if (value < 50)
                    {
                        //il y a nuage
                        ChangeTemps(LesTemps.nuage);
                    }
                    else
                    {
                        if (value < 90)
                        {
                            //il y a pluie
                            ChangeTemps(LesTemps.pluie);
                        }
                        else
                        {
                            //il y a orage
                            ChangeTemps(LesTemps.orage);
                        }
                    }
                }
            }
        }

        private void ChangeTemps(LesTemps myTemps)
        {
            if (ancienTemps.HasValue && ancienTemps.Value != null && eventChangementTemp != null)
            {
                eventChangementTemp(myTemps); //mise en place de l'événement
            }
            ancienTemps = myTemps;
        }


    }




}
