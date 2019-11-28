using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UEFATeams.Models;

namespace UEFATeams.Data
{
    public class TeamData
    {
        private readonly TeamContext db;
        public TeamData(TeamContext teamContext)
        {
            this.db = teamContext;
        }
        public Team Get(int? id) {
            return db.Teams.FirstOrDefault(x => x.TeamId == id);
        }

        public IEnumerable<Team> GetAll() {
            return db.Teams;    
        }

        public void Update(Team team) {
            Team current = this.Get(team.TeamId);
            if (current != null) {
                current.Name = team.Name;
                current.Eliminated = team.Eliminated;
                current.Country = team.Country;
                db.SaveChanges();
            }
        }


    }
}