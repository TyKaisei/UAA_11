using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_MatheisD_DecembreExam
{
    public struct Method
    {
        public void TourJoueur(int numeroJoueur, int nDes, ref string[] historiqueLancers, ref int[] scores)
        {
            string chaine = "";
            int[] desSortis;
            int pointsLancer;

            LanceDes(nDes, out desSortis);
            Concatene(desSortis, out chaine);
            Console.WriteLine(chaine);
            historiqueLancers[numeroJoueur - 1] += chaine + "\n";
            ComptePoints(desSortis, out pointsLancer);
            Console.WriteLine(pointsLancer + "\n");

            if (pointsLancer != -1)
            {
                scores[numeroJoueur - 1] = scores[numeroJoueur - 1] + pointsLancer;
            }
            else
            {
                scores[numeroJoueur - 1] = 0;
            }
            Console.WriteLine(scores[numeroJoueur - 1]);
        }

        public void LanceDes(int nDes, out int[] desSortis)
        {
            Random random = new Random();
            desSortis = new int[nDes];
            for (int i = 0; i < nDes; i++)
            {
                desSortis[i] = random.Next(1, 7);
            }
        }

        public void CompteOccurrences(int[] desSortis, int faceDe, out int nOccurrences)
        {
            nOccurrences = 0;
            for (int i = 0; i <= desSortis.Length - 1; i++)
            {
                if (desSortis[i] == faceDe)
                {
                    nOccurrences += 1;
                }
            }
        }

        public void ComptePoints(int[] desSortis, out int pointsLancer)
        {
            pointsLancer = 0;

            int longueurSuite = 0;
            int face = 1;
            int nOccurrences = 0;
            bool fini = false;
            bool triple1 = false;

            while (!fini && !triple1)
            {
                CompteOccurrences(desSortis, face, out nOccurrences);
                if (face == 1 && nOccurrences >= 3)
                {
                    triple1 = true;
                }
                else if (nOccurrences >= 1)
                {
                    longueurSuite += 1;
                }
                else
                {
                    fini = true;
                }
                face = face + 1;
            }
            if (triple1)
            {
                pointsLancer = -1;
            }
            else if (longueurSuite != 0)
            {
                pointsLancer = 5 * (longueurSuite - 1);
            }
        }


        public void CreerCommentaire(int[] scores, out string commentaire)
        {
            if (scores[0] > scores[1])
            {
                commentaire = "Joueur 1 gagne avec : " + scores[0] + " points contre : " + scores[1] + " pour le joueur 2";
            }
            else if (scores[1] > scores[0])
            {
                commentaire = "Joueur 2 gagne avec : " + scores[1] + " points contre : " + scores[0] + " pour le joueur 1";
            }
            else
            {
                commentaire = "Match nul avec : " + scores[0] + " points";
            }

        }


        public void Concatene(int[] tab, out string chaine)
        {
            chaine = "";
            for (int i = 0; i < tab.Length; i++)
            {
                chaine += tab[i] + ", ";
            }
        }

        public void LireEntier(string question, out int entierUser)
        {
            string eUser;
            Console.WriteLine(question);
            eUser = Console.ReadLine();
            while (!int.TryParse(eUser, out entierUser))
            {
                Console.WriteLine("Veuillez encoder : ");
                Console.WriteLine(question);
                eUser = Console.ReadLine();
            }
        }
    }
}
