using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core_project.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
