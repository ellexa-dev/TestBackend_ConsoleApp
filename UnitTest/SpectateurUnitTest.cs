using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SpectateurUnitTest
    {
        [TestMethod]
        public void TestObtenirReaction()
        {
            var singe = new Exercice1.Singe();
            var tour = singe.RecupererTourEnCours(2);
            var spectateur = new Exercice1.Spectateur();

            spectateur.ObtenirReaction(tour);
        }
    }
}
