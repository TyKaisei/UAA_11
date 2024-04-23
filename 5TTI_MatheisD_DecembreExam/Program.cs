using System.Text.Json;

namespace _5TTI_MatheisD_DecembreExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[2];
            string[] historiqueLancers = new string[2];
            int nombreDes;
            string reponse = "";
            string commentaire;
            
            Method Outils = new Method();

            do
            {
                for (int i = 0; i <= 1; i++)
                {
                    scores[i] = 0;
                    historiqueLancers[i] = "";
                }

                do
                {
                    Outils.LireEntier("Avec combien de dés voulez-vous jouer ? (Entre 6 et 8) ", out nombreDes);
                } while (nombreDes < 6 || nombreDes > 8);

                do
                {
                    for ( int i = 0;i <= 2; i++)
                    {
                        Outils.TourJoueur(i, nombreDes, ref historiqueLancers, ref scores);
                    }

                } while (scores[0] < 50 && scores[1] < 50);

                Console.WriteLine("Dés sorti joueur 1 : " + historiqueLancers[0] + "\nDés sortis joueur 2 : ");

                Outils.CreerCommentaire(scores, out commentaire);
                Console.WriteLine(commentaire + "\n");

                Console.WriteLine("Voulez-vous recommencer à jouer ? oui = espace, non = autre ");
                reponse = Console.ReadLine();


            } while (reponse == " ");

        }
    }
}