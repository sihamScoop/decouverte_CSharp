using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_extension
{
    public static class Encodage
    {
        ////********!debut:version1
        //public static string Crypter(string chaine)
        //{
        //    string chaineCrypt = Convert.ToBase64String(Encoding.Default.GetBytes(chaine));
        //    return chaineCrypt;
        //}

        //public static string DeCrypter(string chaine)
        //{
        //    string chaineDeCrypt = Encoding.Default.GetString(Convert.FromBase64String(chaine));
        //    return chaineDeCrypt;
        //}
        ////********!fin:version1

        //********!debut:version2: utilisation des méthodes d'extensions
        //ici on souhaite avoir des méthodes d'extension de la classe string
        public static string Crypter(this string chaine)
        {
            string chaineCrypt = Convert.ToBase64String(Encoding.Default.GetBytes(chaine));
            return chaineCrypt;
        }

        public static string DeCrypter(this string chaine)
        {
            string chaineDeCrypt = Encoding.Default.GetString(Convert.FromBase64String(chaine));
            return chaineDeCrypt;
        }

        //********!fin:version2
    }
}
