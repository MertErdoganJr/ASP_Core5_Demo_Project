using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Core_project.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace Core_project.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterVeiwModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterVeiwModel p)
        {

            WriterUser w = new WriterUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = p.ImageUrl
            };

            if (p.Password == p.ConfirmPassword)
            {
                var results = await _userManager.CreateAsync(w, p.Password);

                if (results.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(p);
        }
    }
}
