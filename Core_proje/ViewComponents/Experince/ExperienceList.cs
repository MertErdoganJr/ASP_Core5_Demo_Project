using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Core_proje.ViewComponents.Experince
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperinceDal());

        public IViewComponentResult Invoke()
        {
            var valeus = experienceManager.TGetList();
            return View(valeus);
        }
    }
}
