using Design_and_implement_MVC_controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_and_implement_MVC_controllers.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatePlayer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditPlayer()
        {
            byte[] versionArray = new byte[10] { 1, 2, 3, 4, 75, 6, 7, 18, 9, 100 };


            Player player = new Player() { FirstName = "Novak", LastName = "Djokovic", Ranking = "1", Remarks = "Great player" };
            player.Version = new System.Data.Linq.Binary(versionArray);


            return View(player);

        }

        [HttpPost]
        //   public ActionResult EditPlayer([Bind(Prefix = "Contestant")] Player player)
        //public ActionResult EditPlayer([Bind(Exclude = "Ranking")] Player player )
        public ActionResult EditPlayer(Player player)
 
        {

            if (ModelState.IsValid)
            {
                return View(player);
            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult CreatePlayer(Player player)
        {
            return View(player);
            // return DisplayPlayer(player);
        }

        public ActionResult DisplayPlayer(Player player)
        {
            return View("DisplayPlayer", player);
        }
    }
}