namespace _5TTI_MatheisD_ProcédureFonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string questions = "Combien de fois voulez-vous lancer votre dé ? ";
            int n;
            string chaine;
            int[] tableauRandom;
            MesMéthodes Outils = new MesMéthodes();
            Outils.LireReel(questions, out n);
            Outils.TabRdm(n, out tableauRandom);
            Outils.Concatenation(tableauRandom, out chaine);
            Console.WriteLine(chaine);
        }
    }
}