using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    class Program
    {
        static void Main(string[] args)
        {
            new DemoEvenement().Demo();

            //utilisation de la classe EventArgs
            //voir classe : VoitureEvent, ChangementPrixEventArgs, DemoEvenementEvent

            new DemoEvenementEvent().Demo();

            Console.ReadLine();
        }
    }
}
