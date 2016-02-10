using NUnit.Framework;

namespace MathTests.Unit
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Factorielle_AvecValeur3_retourne6()
        {
            int valeur = 3;
            int resultats = MaBibliothequeATester.Math.Factorielle(valeur);
            Assert.AreEqual(6, resultats);
        }

        [Test]
        public void Factorielle_AvecValeur10_retourne1()
        {
            int valeur = 10;
            int resultats = MaBibliothequeATester.Math.Factorielle(valeur);
            Assert.AreEqual(1, resultats,"La valeur doit être égale à 1");
        }
    }
}
