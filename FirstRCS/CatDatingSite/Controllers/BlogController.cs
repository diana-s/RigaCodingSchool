using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;
    //Lai varētu izmantot AddOrUpdate funkciju ir jāpieraksta šis usings, kas apakšā :)
    using System.Data.Entity.Migrations;
    using System.Data.Entity;

    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            using (var blogDb = new BlogDb())
            {
               
                //iegūt blogu sarakstu no blogu datu bāzes tabulas
                var blogListFromDb = blogDb.BlogProfiles.ToList();

                //iegūst skatu ar blogiem no tabulas
                return View(blogListFromDb);

            }

        }
            public ActionResult AddBlog()
            {
                return View();
            }
        
    }
}