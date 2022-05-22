using BusinessLayer.Concrete;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
        public class WriterAboutOnDashboard : ViewComponent
        {
            WriterManager writermanager = new WriterManager(new EfWriterRepository());
            public IViewComponentResult Invoke()
            {
                var values = writermanager.GetWriterById(2);
                return View(values);
            }
        }  
}
