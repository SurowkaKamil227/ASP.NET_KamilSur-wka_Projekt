﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LabPJ.Models
{

    public enum BookStatus
    {
        [Display(Name = "Niedostępna")] Low = 0,
        [Display(Name = "Na wyczerpaniu")] Normal = 1,
        [Display(Name = "Dostępna")] High = 2,
    }
}