using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UEFATeams.Data;
using UEFATeams.Models;

namespace UEFATeams.Controllers
{
    public class TeamController : Controller
    {
        static TeamContext teamContext = new TeamContext();
        static TeamData teamData = new TeamData(teamContext);
        
        public ActionResult Index()
        {

            TeamData teamData = new TeamData(teamContext);
            return View(teamData.GetAll());
        }

        public ActionResult Create() {
            return View();
        }
        
        [HttpGet]
        public ActionResult Details(int? id) {
            if (id == null)
            {
                return View();
            }
            else {
                 TeamDetailsModel teamDetails = new TeamDetailsModel(teamData.Get(id));
                 return View(teamDetails);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(Team team) {
            if (ModelState.IsValid) {
                teamData.Update(team);
                return RedirectToAction("Index");
            }
            return View(team.TeamId);
        }
    }
}