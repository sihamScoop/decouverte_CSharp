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
            CompteCourant compteNicolasC = new CompteCourant(2000) { _nomProprio = "Nicolas" };
            CompteEpargne compteNicolasE = new CompteEpargne(0.02) { _nomProprio = "Nicolas" };
            CompteCourant compteJermie = new CompteCourant(500) { _nomProprio = "Jeremie" };
            
            compteNicolasC.Crediter(100);
            compteNicolasC.Debiter(50);
            
            compteNicolasE.Crediter(20, compteNicolasC);
            compteNicolasE.Crediter(100);
            
            compteNicolasE.Debiter(20, compteNicolasC);

            compteJermie.Debiter(500);
            compteJermie.Debiter(200, compteNicolasC);

            Console.WriteLine("résumé du compte courant  " + compteNicolasC._nomProprio );
            compteNicolasC.AfficherResumer();
            
            Console.WriteLine("résumé du compte courant  " + compteNicolasE._nomProprio);
            compteNicolasE.AfficherResumer();

            ICalculateur_Benef beneficeTauxFixe = new BeneficeTauxFixe(0.275);
            LivretToutBenef livretToutBenefNicolas = new LivretToutBenef(beneficeTauxFixe);
            livretToutBenefNicolas.Crediter(800);
            livretToutBenefNicolas.Debiter(200);

            Console.WriteLine("résumé du livret TouBénef");
            livretToutBenefNicolas.AfficherResumer();
            Console.ReadLine();
        }
    }
}
