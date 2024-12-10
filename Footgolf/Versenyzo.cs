using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footgolf
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Egyesulet { get; set; }
        public int[] Fordulok { get; set; }

        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');

            Nev = s[0];
            Kategoria = s[1];
            Egyesulet = s[2];
            Fordulok = new int[8];
            Fordulok[0] = int.Parse(s[3]);
            Fordulok[1] = int.Parse(s[4]);
            Fordulok[2] = int.Parse(s[5]);
            Fordulok[3] = int.Parse(s[6]);
            Fordulok[4] = int.Parse(s[7]);
            Fordulok[5] = int.Parse(s[8]);
            Fordulok[6] = int.Parse(s[9]);
            Fordulok[7] = int.Parse(s[10]);
        }


    }
}
