using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_MatheisD_SelectionPairsImpairs
{
    public struct Méthodes
    {
        public int ValeurRdm()
        {
            int alea;

            Random random = new Random();
            alea = random.Next(1, 13);

            return alea;
        }

        public void TableauInit(int n, out int[] tabinit)
        {
            tabinit = new int[n];

            for (int i = 0; i < n; i++)
            {
                tabinit[i] = ValeurRdm();
            }
        }

        public void Tableaux(int n, int[] tabinit, out int[] tabPairs, out int[] tabImpairs)
        {
            tabPairs = new int[n];
            tabImpairs = new int[n];

            int indexPairs = 0;
            int indexImpairs = 0;

            for (int i = 0; i < n; i++)
            {
                tabPairs[i] = 0;
                tabImpairs[i] = 0;
            }

            for (int j = 0; j < n; j++)
            {
                if (tabinit[j] % 2 == 0)
                {
                    tabPairs[indexPairs] = tabinit[j];
                    indexPairs++;
                }
                else
                {
                    tabImpairs[indexImpairs] = tabinit[j];
                    indexImpairs++;
                }
            }
        }

        public void AfficherTab(int[] tableau, out string chaineTableau)
        {
            chaineTableau = string.Join(", ", tableau);
        }
    }
}
