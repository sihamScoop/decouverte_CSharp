using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteCourant compteNicolasC = new CompteCourant("Nicolas", 2000);
            CompteEpargne compteNicolasE = new CompteEpargne("Nicolas", 2);
            CompteCourant compteJermie = new CompteCourant("jeremie", 500);
            compteNicolasC.Crediter(100);
            compteNicolasC.Debiter(50);
            compteNicolasC.Crediter(20, compteNicolasE);
            compteNicolasE.Crediter(100);
            compteNicolasE.Debiter(20, compteNicolasC);

            compteJermie.Crediter(500);
            compteJermie.Crediter(200, compteNicolasC);

            Console.WriteLine(compteNicolasC.ToString());
            Console.WriteLine(compteNicolasE.ToString());
            Console.WriteLine(compteJermie.ToString());
            Console.ReadLine();
        }
    }
}
