using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Meteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulateur simulateurmeteo = new Simulateur(1000);
            Statisticien statisticien = new Statisticien(simulateurmeteo);
            statisticien.demarrerAnalyse();
            statisticien.AfficherRapport();

            Console.ReadLine();
        }

       
    }
}
