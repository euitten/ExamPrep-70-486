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

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult CreatePlayer(Player player)
        {
            return View();
        }
    }
}