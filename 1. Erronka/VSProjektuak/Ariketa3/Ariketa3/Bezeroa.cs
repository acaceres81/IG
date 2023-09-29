using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Bezeroa : Kontaktua
    {
        public String kategoria { get; set; }

        public Bezeroa() { }

        public override void gorde()
        {
            MessageBox.Show("Bezeroa ondo gorde da");
        }
        public override String ToString()
        {
            return "gorde duzun bezeroaren izen abizenak " + this.izenOsoa + " da, NANa " + this.nan + ", bere emaila " + this.email + " da eta bere kategoria " + this.kategoria + " da.";
        }

    }


}
