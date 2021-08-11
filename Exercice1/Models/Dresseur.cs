using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public class Dresseur
    {
        public Singe singe;

        public int GetNbToursSinge()
        {
            int nbTours = singe.DonnerToursConnus();
            return nbTours;
        }
    }
}
