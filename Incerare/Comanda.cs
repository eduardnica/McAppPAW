using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incerare
{
    class Comanda
    {
        public DateTime dataPlasare;
        public DateTime dataLivrare;
        public Client client;
        public List<Produs> produse;
        public Angajat angajat;
        public double pretComanda;
        

        public Comanda(DateTime dataPlasare, DateTime dataLivrare, Client client, List<Produs> produse, Angajat angajat, double pretComanda)
        {
            this.dataPlasare = dataPlasare;
            this.dataLivrare = dataLivrare;
            this.client = client;
            this.produse = produse;
            this.angajat = angajat;
            this.pretComanda = pretComanda;
        }
    }
}
