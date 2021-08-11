using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TourUnitTest
    {
        [TestMethod]
        public void TestGetTypeTour()
        {
            var singe = new Exercice1.Singe();
            var tour = singe.RecupererTourEnCours(2);
            var typeTour = tour.ObtenirTypeTour();
        }

        [TestMethod]
        public void TestObtenirNouveauTour()
        {
            var tour = Exercice1.Models.Tour.ObtenirNouveauTour();
        }
    }
}
