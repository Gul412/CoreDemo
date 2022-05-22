﻿using BusinessLayer.Concrete;
using DAL.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c=new Context();
            ViewBag.v1=c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == 2).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
