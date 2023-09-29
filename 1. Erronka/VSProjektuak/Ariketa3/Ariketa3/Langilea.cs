using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Langilea : Kontaktua
    {
        public Langilea() { }
        public float soldata { get; set; }
        public String segurtasuSoziala { get; set; }
        public override String email
        {
            get => base.email;
            set
            {
                try { 
                    if (value.Substring(value.Length - 14, 14) != "@iesunibhi.com")
                    {

                        Exception ex = new Exception("Emaila ez duzu ondo jarri");
                        throw ex;
                    }
                    else
                    {
                        base.email = value;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Restart();
                }
            }

        }

        public override String ToString()
        {
            return "gorde duzun kontaktuaren izen abizenak " + this.izenOsoa + " da, NANa " + this.nan + ", bere emaila " + this.email + " da eta bere soldata " + this.soldata + " da.";
        }
    }
}
