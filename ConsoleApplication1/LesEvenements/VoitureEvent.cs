using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    public class VoitureEvent
    {
        public event EventHandler<ChangementPrixEventArgs> ChangePrice;
        public decimal Price { get; set; }

        public void ChangementPrice(int nombre)
        {
            Price = Price / nombre;
            if (ChangePrice != null)
            {
                ChangePrice(this, new ChangementPrixEventArgs { Prix = Price });
            }
        }
    }
}
