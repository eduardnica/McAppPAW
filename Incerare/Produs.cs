using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incerare
{
    class Produs
    {
        public string denumireProdus;
        public string codProdus;
        public double pretProdus;

        public Produs(string denumireProdus, string codProdus, double pretProdus)
        {
            this.denumireProdus = denumireProdus;
            this.codProdus = codProdus;
            this.pretProdus = pretProdus;
        }

        //public override string ToString()
        //{
        //    return this.denumireProdus + " " + this.codProdus;
        //}
    }
}
