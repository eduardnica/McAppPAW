using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incerare
{
    class Angajat : Persoana
    {
        private string idAngajat;
        private int salariu;

        public Angajat(string nume, string prenume, DateTime dataNasterii, string nrTelefon, string adresa, string idAngajat, int salariu) :
            base(nume, prenume, dataNasterii, nrTelefon, adresa)
        {
            this.idAngajat = idAngajat;
            this.salariu = salariu;
        }
    }
}
