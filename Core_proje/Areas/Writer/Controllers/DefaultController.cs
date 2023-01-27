using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace Core_project.Areas.Writter.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = announcementManager.TGetByID(id);
            return View(announcement);
        }
    }
}
