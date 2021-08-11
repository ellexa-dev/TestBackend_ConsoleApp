using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialisation
            Spectateur spectateur = new Spectateur();
            Dresseur dresseur1 = new Dresseur();
            Dresseur dresseur2 = new Dresseur();
            Singe singe1 = new Singe();
            Singe singe2 = new Singe();

            dresseur1.singe = singe1;
            dresseur2.singe = singe2;

            Console.WriteLine("Pendant la visite d'un cirque, un spectateur croise deux dresseurs de singe ! Voulez-vous demander à un des dresseurs de montrer ce qu'il sait faire? (O/N)");
            while (true)
            {
                InteractionUtilisateur(dresseur1, dresseur2, spectateur);
                Console.WriteLine("Voulez-vous demander une autre démonstration O/N?");
            }
            
        }

        public static int ChoixTour(Dresseur dresseur, Spectateur spectateur)
        {
            Console.WriteLine("Le dresseur énumère les tours connus par son singe :");
            int nbTours = dresseur.GetNbToursSinge();
            Console.WriteLine("Quel tour voulez-vous que le dresseur demande à son singe de démontrer?");
            string choixTour = "";
            int idTour = 0;
            bool tourChoisi = false;
            while (!tourChoisi)
            {
                choixTour = Console.ReadLine();
                idTour = int.Parse(choixTour);
                if (idTour < 0 || idTour > nbTours)
                    Console.WriteLine("Le singe ne connait pas ce tour, veuillez choisir un tour connu.");
                else
                    tourChoisi = true;
            }
            return idTour-1;
        }

        public static void MontrerTour(Dresseur dresseur, Spectateur spectateur, int idTour)
        {
            dresseur.singe.DemonstrationTour(idTour);
            Console.WriteLine(spectateur.GetReaction(dresseur.singe.RecupererTourEnCours(idTour)));
            
        }

        public static void InteractionUtilisateur(Dresseur dresseur1, Dresseur dresseur2, Spectateur spectateur)
        {
            string reponse = "";
            while (reponse != "O" && reponse != "o" && reponse != "n" && reponse != "N")
            {
                reponse = Console.ReadLine();
                if (reponse != "O" && reponse != "o" && reponse != "n" && reponse != "N")
                    Console.WriteLine("Il doit y avoir une erreur, veuillez répondre par O(oui) ou N(non).");
            }

            if (reponse == "O" || reponse == "o")
            {
                Console.WriteLine("Quel dresseur choisissez-vous pour cette démonstration? \n1 : Dresseur 1 \n2 : Dresseur 2");
                string choixDresseur = "";
                while (choixDresseur != "1" && choixDresseur != "2")
                {
                    choixDresseur = Console.ReadLine();
                    if (choixDresseur != "1" && choixDresseur != "2")
                        Console.WriteLine("Il doit y avoir une erreur, veuillez répondre par 1 ou 2.");
                }
                int idTour;
                if (choixDresseur == "1")
                {
                    idTour = ChoixTour(dresseur1, spectateur);
                    MontrerTour(dresseur1, spectateur, idTour);
                }
                else if (choixDresseur == "2")
                {
                    idTour = ChoixTour(dresseur2, spectateur);
                    MontrerTour(dresseur2, spectateur, idTour);
                }
            }
            else if (reponse == "N" || reponse == "n")
            {
                Console.WriteLine("Le spectateur continue sa visite du cirque...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
