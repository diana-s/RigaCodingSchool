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
            var blogFromDb = new Blog();
           blogFromDb.BlogName = "Pūciņa";
            blogFromDb.BlogAuthor = "Diana";
            blogFromDb.BlogImage = "https://ichef.bbci.co.uk/images/ic/208x117/p0517py6.jpg";


            using (var blogDb = new CatDb())
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
        [HttpPost]
        public ActionResult AddBlog(Blog userBlog)
        {
            if (ModelState.IsValid == false)
            {
                return View(userBlog);
            }

            userBlog.BlogCreated = DateTime.Now;

            userBlog.BlogEdited = DateTime.Now;

            using (var BlogDb = new CatDb())
            {
                BlogDb.BlogProfiles.Add(userBlog);
                BlogDb.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}