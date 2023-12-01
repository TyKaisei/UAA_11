namespace _5TTI_MatheisD_SelectionPairsImpairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int[] tabInit;
            int[] tabPairs;
            int[] tabImpairs;

            string chaineInit, chainePairs, chaineImpairs;

            Méthodes Outils = new Méthodes();

            Outils.TableauInit(n, out tabInit);
            Outils.Tableaux(n, tabInit, out tabPairs, out tabImpairs);

            Outils.AfficherTab(tabInit, out chaineInit);
            Outils.AfficherTab(tabPairs, out chainePairs);
            Outils.AfficherTab(tabImpairs, out chaineImpairs);

            Console.WriteLine("Tableau initial : " + chaineInit + "\nTableau Pairs : " + chainePairs + "\nTableau Impairs : " + chaineImpairs);
        }
    }
}