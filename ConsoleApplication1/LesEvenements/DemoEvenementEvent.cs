using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    public class DemoEvenementEvent
    {
        public void Demo()
        {
            VoitureEvent car = new VoitureEvent { Price = 10000 };
            car.ChangePrice += Car_ChangePrice;
            car.ChangementPrice(4);
        }

        private void Car_ChangePrice(object sender, ChangementPrixEventArgs e)
        {
            //object sender : représente la voiture
            //ChangementPrixEventArgs e : représente l'objet contenant le prix de la voiture en promotion
            Console.WriteLine("Le nouveau prix est : " + e.Prix);
        }
    }
}
