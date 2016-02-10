﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaBibliothequeATester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliothequeATester.Tests
{
    [TestClass()]
    public class MathTests
    {
        [TestMethod()]
        public void Factorielle_AvecValeur3_retourne6()
        {
            int valeur = 3;
            int resultats = MaBibliothequeATester.Math.Factorielle(valeur);
            Assert.AreEqual(6, resultats);
        }

        [TestMethod()]
        public void Factorielle_AvecValeur10_retourne1()
        {
            int valeur = 10;
            int resultats = MaBibliothequeATester.Math.Factorielle(valeur);
            Assert.AreEqual(1, resultats, "La valeur doit être égale à 1");
        }
    }
}