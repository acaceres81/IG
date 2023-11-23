using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    public class Osagaia
    {
        [Key]
        public int Id { get; set; }
        public String Izena { get; set; }
        public String Unitatea { get; set; }
        public int Konparaketa { get; set;}
    }
}
