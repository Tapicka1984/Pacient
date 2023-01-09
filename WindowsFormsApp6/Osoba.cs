using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Osoba
    {
        string jmeno;
        string prijmeni;
        int vaha;
        double vyska;
        public Osoba(string jmeno, string prijmeni, int vaha, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vaha = vaha;
            this.vyska = vyska;
        }

        public string BMI()
        {
            return "BMI osoby: " + jmeno + prijmeni + "je: " + ((vaha / ((vyska / 100) * 2)));
        }
    }
}
