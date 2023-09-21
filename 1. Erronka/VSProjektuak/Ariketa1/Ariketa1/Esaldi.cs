using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa1
{
    internal class Esaldi
    {
        private String esaldibatua;

        public String zatia {  get; set; }

        public void Lotu()
        {
            esaldibatua += " " + zatia;
        }
    }
}
