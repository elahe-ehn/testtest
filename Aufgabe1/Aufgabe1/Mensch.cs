using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Mensch
    {
        public string name;
        public int soz_nummer;
        int alter;
        private int kontostand;



       


        public Mensch()
        {
            name = "elahe";
            soz_nummer = 123;
            alter = 22;
            kontostand = 0;

        }

       public Mensch(string name, int soz_nummer, int alter, int kontostand)
        {
            this.name = name;
            this.soz_nummer = soz_nummer;
            this.alter = alter;
            this.kontostand = kontostand;
        }


        public int get_kontostand()
        {

            return kontostand;
        }

        public override void printdd()
        {

            Console.WriteLine("Name " + name + " soz_nummer " + soz_nummer + " alter " + alter + " kontostand " + kontostand );

        }
    }
}
