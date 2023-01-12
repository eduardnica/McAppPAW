using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incerare
{
    class Persoana
    {
        public string nume;
        public string prenume;
        public DateTime dataNasterii;
        public string nrTelefon;
        public string adresa;

        public Persoana(string nume, string prenume, DateTime dataNasterii, string nrTelefon, string adresa)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.dataNasterii = dataNasterii;
            this.nrTelefon = nrTelefon;
            this.adresa = adresa;
        }

       


    }
}
