using BusinessLayer.Concrete;
using DAL.Concrete;
using DAL.EntityFramework;
using EntityKatmani.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
        public class WriterAboutOnDashboard : ViewComponent
        {
            WriterManager writermanager = new WriterManager(new EfWriterRepository());
            Context c = new Context();

        public IViewComponentResult Invoke()
            {
            var username = User.Identity.Name;
            ViewBag.v = username;
           var usermail=c.Users.Where(x => x.UserName == username)
                .Select(y=>y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail)
             .Select(y => y.WriterID).FirstOrDefault();
            var values = writermanager.GetWriterById(writerID);
            return View(values);
        }
       
    }  
}
