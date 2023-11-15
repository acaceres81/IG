using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cookpad
{
    //asegurate de que esta clase es publica
    public class BotoaForm
    {
        
        public String nan { get; set; }
        public string izena { get; set; }

        public String email { get; set; }

        public String ezizena { get; set; }

        public String errezetaId { get; set; }

        public void gorde(String izena)
        {
            MessageBox.Show(izena + " zure botoa ondo gorde da");
        }

    }

    
}
