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

            for (int i = 0; i < Fordulok.Length; i++)
            {
                Fordulok[i] = int.Parse(s[i + 3]);
            }
        }


    }
}
