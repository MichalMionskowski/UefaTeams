using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UEFATeams.Models
{
    public class TeamDetailsModel
    {
        public TeamDetailsModel(Team team)
        {
            this.team = team;
            this.countries = Country.GetCountries(); 
        }
        public Team team;

        public IEnumerable<Country> countries;
    }
}