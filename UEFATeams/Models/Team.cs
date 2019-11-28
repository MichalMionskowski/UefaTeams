using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UEFATeams.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public bool Eliminated { get; set; }
    }
}