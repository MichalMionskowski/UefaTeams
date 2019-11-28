using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UEFATeams.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext():base("UEFATeamsContext")
        {

        }
        public DbSet<Team> Teams { get; set; }
    }
}