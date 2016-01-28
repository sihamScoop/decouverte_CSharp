using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuitePOO
{
    public class Chat : Animal
    {
        ////********!debut:version2
        ////public Chat(string prenomChat)
        ////{
        ////    this.prenom = prenomChat;
        ////} //équivalentà
        //public Chat(string prenomChat)
        //    : base(prenomChat)
        //{

        //}

        //public void Miauler()
        //{
        //    Console.WriteLine("Miaou !!");
        //}
        ////********!fin:version2

        ////********!debut:version3
        //public Chat(string prenomChat)
        //{
        //    this.prenom = prenomChat;
        //}
        //public void Miauler()
        //{
        //    Console.WriteLine("Miaou !!");
        //}
        ////********!fin:version3

        //********!debut:test des variables objet
        public void Miauler()
        {
            Console.WriteLine("Miaou !!");
        }
    }
}
