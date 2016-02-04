using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Meteo
{
    public class Statisticien
    {
        private Simulateur monSimulateur;
        private int nombreChangementTemps;
        private int nombreTempsSoleil;

        public Statisticien(Simulateur simul)
        {
            monSimulateur = simul;
            nombreChangementTemps = 0;
            nombreTempsSoleil = 0;
        }

        public void demarrerAnalyse()
        {
            //réinitialisation des compteurs
            nombreChangementTemps = 0;
            nombreTempsSoleil = 0;
            monSimulateur.EventquandLeTempsChange += MonSimulateur_EventquandLeTempsChange;
            monSimulateur.Demarrer();
            //désabonnement une fois l'analyse fini
            monSimulateur.EventquandLeTempsChange -= MonSimulateur_EventquandLeTempsChange;
        }

        private void MonSimulateur_EventquandLeTempsChange(Temps temps)
        {
            if (temps == Temps.Soleil)
            {
                nombreTempsSoleil++;
            }
            nombreChangementTemps++;
        }

        public void AfficherRapport()
        {
            Console.WriteLine("Nombre de fois  ou le temps a changé : " + nombreChangementTemps);
            Console.WriteLine("Nombre de fois ou il a fait soleil : " + nombreTempsSoleil);
           
                Console.WriteLine("pourcentage de beau temps : " + (nombreTempsSoleil * 100 / nombreChangementTemps)  + "%");
            
           
        }
    }
}
