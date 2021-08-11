using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    /// <summary>
    /// Description résumée pour SpectateurUnitTest
    /// </summary>
    [TestClass]
    public class SpectateurUnitTest
    {
        [TestMethod]
        public void TestGetReaction()
        {
            var singe = new Exercice1.Singe();
            var tour = singe.RecupererTourEnCours(2);
            var spectateur = new Exercice1.Spectateur();

            spectateur.GetReaction(tour);
        }
    }
}
