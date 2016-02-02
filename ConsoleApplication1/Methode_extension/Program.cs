using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            ////********!debut:version1
            //string chaineInitiale = "je suis malade, mais je me soigne";
            //string chaineCryptee=Encodage.Crypter(chaineInitiale);
            //Console.WriteLine("voici la pharse crypté :");
            //Console.WriteLine(chaineCryptee);
            //chaineInitiale = Encodage.DeCrypter(chaineCryptee);
            //Console.WriteLine("voici la pharse décrypté :");
            //Console.WriteLine(chaineInitiale);
            ////********!fin:version1

            //********!debut:version2
            string chaineInitiale = "je suis malade, mais je me soigne";
            string chaineCryptee = chaineInitiale.Crypter();
            Console.WriteLine("voici la pharse crypté :");
            Console.WriteLine(chaineCryptee);
            chaineInitiale = chaineCryptee.DeCrypter();
            Console.WriteLine("voici la pharse décrypté :");
            Console.WriteLine(chaineInitiale);
            //********!fin:version2

            //********!debut:version3
            Avion avion = new Avion();
            Oiseau oideau = new Oiseau();
            avion.Atterir();
            oideau.Atterir();
            //********!fin:version3

            Console.ReadLine();
        }
    }
}
