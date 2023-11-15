using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookpad.Models
{
    //asegurate de que esta clase es publica
    public class Botoa
    {
        private Errezeta errezeta;

        [Key]
        public int Id { get; set; }
        public string ErabiltzaileaId { get; set; }
        public int ErrezetaId { get; set; }
        public string Urtea { get; set; }
        public string Komentarioa { get; set; }

        public Errezeta Errezeta { get => errezeta; set => errezeta = value; }
        //public virtual Erabiltzailea ErabiltzaileBat { get; set; }

    }
}
