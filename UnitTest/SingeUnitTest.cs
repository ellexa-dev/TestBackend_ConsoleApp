using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SingeUnitTest
    {
        [TestMethod]
        public void TestDonnerTours()
        {
            var singe = new Exercice1.Singe();
            int toursConnus = singe.DonnerToursConnus();
        }

        [TestMethod]
        public void TestDemontrerTour()
        {
            var singe = new Exercice1.Singe();
            singe.DemonstrationTour(2);
        }

        [TestMethod]
        public void TestRecupererTourEnCours()
        {
            var singe = new Exercice1.Singe();
            var tour = singe.RecupererTourEnCours(2);
        }

    }
}
