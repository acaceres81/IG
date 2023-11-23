using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrinfoForm.Models
{
    public class Informazioa
    {

        [Key]
        public int Id { get; set; }
        public virtual Osagaia Osagaia { get; set; }
        public int Urtea { get; set; }
        public int Kantitaea { get; set; }
        public virtual Elikagaia Elikagaia { get; set ; }
        
    }
}
