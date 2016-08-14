﻿using System.Web.Mvc;
using System.Linq;

namespace Forum.Controllers
{

    using Forum.Models;
    [RequireHttps]
    public class HomeController : Controller
    {
        protected readonly ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var categories = db.Categories;
            return View(categories);
        }

        // GET: Users with points
        [OutputCache(Duration = 120, VaryByParam = "none")]
        public ActionResult Users()
        {
            ViewBag.Message = "Arduino Tech Forum";

          
            
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

    }
}