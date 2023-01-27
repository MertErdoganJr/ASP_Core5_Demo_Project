using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core_project.Areas.Writer.Models

{
    public class UserRegisterVeiwModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen URL Değeri Girin")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]
        [Compare("Password", ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Lütfen Mail Girin")]
        public string Mail { get; set; }

    }
}
