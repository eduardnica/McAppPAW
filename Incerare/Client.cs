using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incerare
{
    class Client : Persoana
    {
        public string idClient;

        public Client(string nume, string prenume, DateTime dataNasterii, string nrTelefon, string adresa, string idClient) :
            base(nume, prenume, dataNasterii, nrTelefon, adresa)
        {
            this.idClient = idClient;

        }

    }
}
