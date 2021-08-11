using Exercice1.Models;
using System;
using System.Collections.Generic;

namespace Exercice1
{
    public class Singe
    {
        private List<Tour> tours = new List<Tour>();

        public Singe()
        {
            ApprendreTours();
        }

        private void ApprendreTours()
        {
            for(int i=0; i<5; i++)
            {
                while (tours.Count == i)
                {
                    Tour tourEnApprentissage = Tour.ObtenirNouveauTour();
                    bool isAlreadyLearned = false;
                    foreach(Tour tour in tours)
                    {
                        isAlreadyLearned = (tour.name == tourEnApprentissage.name);
                    }
                    if (!isAlreadyLearned)
                    {
                        tours.Add(tourEnApprentissage);
                    }
                }
            }
        }

        public int DonnerToursConnus()
        {
            int nbTours = 0;
            foreach(Tour tour in tours)
            {
                Console.WriteLine(nbTours+1 + " : " + tour.name);
                nbTours++;
            }
            return nbTours;
        }

        public void DemonstrationTour(int tour)
        {
            Console.WriteLine("*" + tours[tour].description + "*");
        }

        public Tour RecupererTourEnCours(int tour)
        {
            return tours[tour];
        }
    }
}
