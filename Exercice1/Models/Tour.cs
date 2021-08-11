using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1.Models
{
    public class Tour
    {
        public enum TypeTour
        {
            Accrobatie, 
            Musique
        }

        public string name;
        public string type;
        public string description;

        public TypeTour GetTypeTour()
        {
            if (type == TypeTour.Accrobatie.ToString())
                return TypeTour.Accrobatie;
            else
                return TypeTour.Musique;
        }

        private static List<Tour> toursEnseignables = new List<Tour>()
        {
            new Tour(){name = "Marcher sur les mains", type = TypeTour.Accrobatie.ToString(), description="Le singe marche sur les mains" },
            new Tour(){name = "Faire du cerceau", type = TypeTour.Accrobatie.ToString(), description="Le singe fait du cerceau" },
            new Tour(){name = "Faire la roue", type = TypeTour.Accrobatie.ToString(), description="Le singe fait la roue" },
            new Tour(){name = "Faire du vélo", type = TypeTour.Accrobatie.ToString(), description="Le singe fait du vélo" },
            new Tour(){name = "Jongler avec des bananes", type = TypeTour.Accrobatie.ToString(), description="Le singe jongle avec des bananes" },
            new Tour(){name = "Jouer de la trompette", type = TypeTour.Musique.ToString(), description="Le singe joue de la trompette" },
            new Tour(){name = "Jouer du tambour", type = TypeTour.Musique.ToString(), description="Le singe joue du tambour" },
            new Tour(){name = "Jouer des cymbales", type = TypeTour.Musique.ToString(), description="Le singe joue des cymbales" },
            new Tour(){name = "Jouer de la flûte", type = TypeTour.Musique.ToString(), description="Le singe joue de la flûte" },
            new Tour(){name = "Jouer du piano", type = TypeTour.Musique.ToString(), description="Le singe joue du piano" }
        };

        public static Tour GetNewTour()
        {
            Random r = new Random();
            int tourNb = r.Next(0, 9);
            return toursEnseignables[tourNb];
        }
    }
}
