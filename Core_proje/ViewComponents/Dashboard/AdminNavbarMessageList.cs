using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Core_project.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList :ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.WriterMessageID).Take(3).ToList();
            return View(values);
        }
    }
}
