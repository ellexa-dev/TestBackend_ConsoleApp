using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    /// <summary>
    /// Description résumée pour TourUnitTest
    /// </summary>
    [TestClass]
    public class TourUnitTest
    {
        [TestMethod]
        public void TestGetTypeTour()
        {
            var singe = new Exercice1.Singe();
            var tour = singe.RecupererTourEnCours(2);
            var typeTour = tour.GetTypeTour();
        }

        [TestMethod]
        public void TestGetNewTour()
        {
            var tour = Exercice1.Models.Tour.GetNewTour();
        }
    }
}
