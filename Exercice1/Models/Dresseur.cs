namespace Exercice1
{
    public class Dresseur
    {
        public Singe singe;

        public int RecupererNbToursSinge()
        {
            int nbTours = singe.DonnerToursConnus();
            return nbTours;
        }
    }
}
