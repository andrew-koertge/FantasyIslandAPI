﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyIsland.Models
{
    public class GuestCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}