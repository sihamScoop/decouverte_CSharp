using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_meteo_moi
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulateur simulateur = new Simulateur(1000);
            Statisticien statsiticien = new Statisticien(simulateur);
            statsiticien.lancerSimulateur();
            statsiticien.Affichagerapport();

            Console.ReadLine();
        }
    }
}
