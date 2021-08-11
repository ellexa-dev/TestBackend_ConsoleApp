using Exercice1.Models;

namespace Exercice1
{
    public class Spectateur
    {

        public string ObtenirReaction(Tour tourSinge)
        {
            if (tourSinge.ObtenirTypeTour() == Tour.TypeTour.Accrobatie)
                return "*Le spectateur applaudit*";
            else
                return "*Le spectateur siffle*";
        }
    }
}
