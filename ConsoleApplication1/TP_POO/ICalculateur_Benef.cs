using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public interface ICalculateur_Benef
    {
        decimal CalculBenefice(decimal solde);
        double taux { get; }
    }
}
