using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_MatheisD_ProcédureFonctions
{
    public struct MesMéthodes
    {
        public int NbRandom()
        {
            int alea;

            Random random = new Random();
            alea = random.Next(1, 7);

            return alea;
        }

        public void LireReel(string question, out int n)
        {

            string nUser;

            do
            {
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            } while (!int.TryParse(nUser, out n));

        }

        public void TabRdm(int n, out int[] tab)
        {

            tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                tab[i] = NbRandom();
            }
        }

        public void Concatenation(int[] tableauRandom, out string chaine)
        {
            chaine = "";

            for (int i = 0; i < tableauRandom.Length; i++)
            {
                chaine = chaine + tableauRandom[i] + ", ";
            }
        }
    }
}
