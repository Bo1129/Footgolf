namespace Footgolf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            foreach (var sor in File.ReadAllLines("fob2016.txt"))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            //3.feladat
         
                Console.WriteLine($"3. feladat: Versenyzok száma: {versenyzok.Count}");
            //4.feladat
            int noi = 0;
            foreach (var v in versenyzok)
            {
                if (v.Kategoria == "Noi")
                {
                    noi++;
                }
            }
            Console.WriteLine($"4.feladat: A női versenyzők aránya: {(noi/(double)versenyzok.Count)*100:0.00}%");
            

        }
    }
}
