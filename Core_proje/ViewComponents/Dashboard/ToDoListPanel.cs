using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace Core_project.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
