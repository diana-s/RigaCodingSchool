using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Lai varētu ievadīt un parādīt vairākus kaķus, ir jāizveido saraksts List
            var CatListFromDb = new List<CatProfile>();

            //taču mēs lista neko neglabāsim, glabāsim uzreiz datu bāzē, tapēc mēs listu dzesīsim arā

            //izveido pirmo kaķa profilu
            var catFromDb = new CatProfile();
            catFromDb.CatName = "Pūciņa";
            catFromDb.CatAge = 5;
            catFromDb.CatImage = "https://ichef.bbci.co.uk/images/ic/208x117/p0517py6.jpg";

            //Pievienojam šo kaķi sarakstam
            CatListFromDb.Add(catFromDb);

            //Izveidojam otra kaķa profilu
            var anothercatFromDb = new CatProfile();
            anothercatFromDb.CatName = "Rexis";
            anothercatFromDb.CatAge = 4;
            anothercatFromDb.CatImage = "http://atlantaintownpaper.com/wp-content/uploads/2013/07/home-cat.jpg";
            //pievienojam arī šo kaķi sarakstam
            CatListFromDb.Add(anothercatFromDb);

            return View(CatListFromDb);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.Diana";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}