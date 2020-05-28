﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EBANK.Models
{
    public class KreditBaza
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Broj računa")]
        public Racun Racun { get; set; }

        [Display(Name = "Iznos")]
        public float Iznos { get; set; }

        [Display(Name = "Kamatna stopa")]
        public float KamatnaStopa { get; set; }

        [Display(Name = "Rok otplate")]
        public DateTime RokOtplate { get; set; }
       
    }
}
