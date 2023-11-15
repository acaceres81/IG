using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookpad.Models
{
    //asegurate de que esta clase es publica
    public class Errezeta
    {
        [Key]
        public int Id { get; set; }
        public string Izena { get; set; }
        public string Deskribapena { get; set; }
    }
}
