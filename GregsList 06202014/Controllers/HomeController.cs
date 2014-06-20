using GregsList06202014.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GregsList06202014.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Category> Categories = Singleton.Instance.Categories;
            return View(Categories);
        }

        public ActionResult cat(int id, string query)
        {            
            List<Post> Posts = Singleton.Instance.Posts.Where(p => p.CategoryId == id).ToList();
            return View(Posts);
        }

        public ActionResult post(int id)
        {
            Post post = Singleton.Instance.Posts.Where(p => p.Id == id).FirstOrDefault();
            return View(post);
        }
    }
}