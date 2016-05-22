using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_and_implement_MVC_controllers.Models
{
    public class Player
    {
   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ranking { get; set; }
        [AllowHtml]
        public string Remarks { get; set; }
    }   
}