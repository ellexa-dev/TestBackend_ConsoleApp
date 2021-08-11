using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class DresseurUnitTest
    {
        [TestMethod]
        public void TestRecupererNbToursSinge()
        {
            var dresseur = new Exercice1.Dresseur();
            var singe = new Exercice1.Singe();
            dresseur.singe = singe;
            int nbTours = dresseur.RecupererNbToursSinge();
        }
    }
}
