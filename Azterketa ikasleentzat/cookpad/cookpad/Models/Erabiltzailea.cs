﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookpad.Models
{
    //asegurate de que esta clase es publica
    public class Erabiltzailea
    {
        [Key]
        public int Id { get; set; }
        public string Izena { get; set; }
        public string Emaila { get; set; }
        public string Ezizena { get; set; }
    }
}
