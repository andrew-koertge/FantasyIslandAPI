﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyIsland.Models
{
    public class GuestListItem
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        //[Display(Name="Created")]
        //public DateTimeOffset CreatedUtc { get; set; }
    }
}
