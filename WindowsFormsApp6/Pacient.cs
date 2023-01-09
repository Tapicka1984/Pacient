using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Pacient : Osoba
    {
        string jmeno;
        string prijmeni;
        int vaha;
        double vyska;
        public Pacient(string jmeno, string prijmeni, int vaha, double vyska) : base(jmeno, prijmeni, vaha, vyska)
        {

        }
    }
}
