using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class Outils
    {
        public static void AffichageOperations(List<Operation> listeOperation)
        {
            Console.WriteLine("Les opérations");
            foreach (Operation oper in listeOperation)
            {
                if (oper.typeMouvement == Mouvement.Credit)
                {
                    Console.WriteLine("\t + ");
                }
                else
                {
                    Console.WriteLine("\t - ");
                }
                Console.WriteLine(oper._montant);
            }
        }
    }
}
