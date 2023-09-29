using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Kontaktua
    {
        public String nan {  get; set; }
        public string izena { get; set; }

        public String abizena { get; set; }
        // Si le ponemos virtual al atributo se puede sobreescribir en las clases hijas.
        public virtual String email { get; set; } 
        public String izenOsoa { 
            get=> this.izena + " " + this.abizena; //
        }

        public virtual void gorde()
        {
            MessageBox.Show("Kontaktua ondo gorde da");
        }
        public Kontaktua() { }

        public override String ToString()
        {
            return "gorde duzun kontaktuaren izen abizenak " + this.izenOsoa + " da, NANa " + this.nan + " eta bere emaila " + this.email + " da";
        }
    }
}
