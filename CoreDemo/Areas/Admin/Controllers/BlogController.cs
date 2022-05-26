using BusinessLayer.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        BlogManager blogmanager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogmanager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
