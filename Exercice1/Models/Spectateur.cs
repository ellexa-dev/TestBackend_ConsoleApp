using Exercice1.Models;

namespace Exercice1
{
    public class Spectateur
    {

        public string GetReaction(Tour tourSinge)
        {
            if (tourSinge.GetTypeTour() == Tour.TypeTour.Accrobatie)
                return "*Le spectateur applaudit*";
            else
                return "*Le spectateur siffle*";
        }
    }
}
