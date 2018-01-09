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
        
        public ActionResult EditBlog(int editableBlogId)

        {
           
            using (var BlogDb = new CatDb())
            {
                var editableBlogt = BlogDb.BlogProfiles.First(Blog =>Blog.BlogID == editableBlogId);
               

                return View("EditBlog", editableBlogt);

               
            }
            
        } 

        [HttpPost]
        public ActionResult EditBlog(Blog model)
        {

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            using(var BlogDb = new CatDb())
            {

                BlogDb.Entry(model).State = EntityState.Modified;
                model.BlogEdited = DateTime.Now;
                BlogDb.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteBlog(int deletableBlogId)

        {
            using (var BlogDb = new CatDb())
            {
                var deletableBlog = BlogDb.BlogProfiles.First(Blog => Blog.BlogID == deletableBlogId);
                BlogDb.BlogProfiles.Remove(deletableBlog);
                BlogDb.SaveChanges();
            }
            return RedirectToAction("Index");

        }


    }
}