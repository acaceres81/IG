using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2v1
{
    

    internal class Eragiketa
    {
        public float Za { get; set; }
        public float Zb { get; set; }
        public float Zc { get; set; }
        public float Zd { get; set; }

        public Eragiketa() { }

        public String eragiketa()
        {
            return "(" + Za + " + 2" + Zb  + " + 3" +  Zc + " + 4"+ Zd + ") / 4 = "emaitza;
        }
    }

   
}
