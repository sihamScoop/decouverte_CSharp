using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_meteo_moi
{
    public class Statisticien
    {

        private Simulateur simul;
        private int nombreJourEnsoleillee;
        private int nombreDeChangement;

        public Statisticien(Simulateur simul)
        {
            this.simul = simul;
            nombreJourEnsoleillee=0;
            nombreDeChangement=0;
        }

        public void lancerSimulateur()
        {
            simul.eventChangementTemp += Simul_eventChangementTemp; //création de l'abonnement
            simul.DemarrerSimulateur();
        }

        //création de la méthode qui va levé l'événement
        private void Simul_eventChangementTemp(LesTemps temps)
        {
            if (temps == LesTemps.soleil)
            {
                nombreJourEnsoleillee++;
            }
            nombreDeChangement++; //à chaque changement de temps on va incrémenter le compteur
        }

        public void Affichagerapport()
        {
            Console.WriteLine("nombre jour avec soelil : " + nombreJourEnsoleillee);
            Console.WriteLine("nombre de changement de temps : " + nombreDeChangement);
            Console.WriteLine("les stats : " + nombreJourEnsoleillee*100/nombreDeChangement +"%");
        }
    }
}
