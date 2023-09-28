using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2Zerrenda
{
    internal class Ariketa
    {
        public String label { get; set; }
        public double zenbakia { get; set; }
        public Ariketa(double zenbakia)
        {
            this.zenbakia = zenbakia;
        }

        

        public static double eragiketa(List<Ariketa> objetuak)
        {

            return ((objetuak[0]).zenbakia + 2 * objetuak[1].zenbakia+ + 3 * objetuak[2].zenbakia + 4 * objetuak[3].zenbakia) / 4;
        }
    }


}
