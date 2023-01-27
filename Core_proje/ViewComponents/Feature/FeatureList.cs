using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureMaanger = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureMaanger.TGetList();
            return View(values);
        }
    }
}
