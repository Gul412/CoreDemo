using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Ad Soyad Giriniz")]
        public string NameSurname { get; set; }


        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Şifrenizi Giriniz")]
        [MaxLength(15,ErrorMessage ="Karakter Sayısı 15ten Az Olmalı")]
        [MinLength(5, ErrorMessage = "Karakter Sayısı 5ten Fazla Olmalı")]
        

        public string Password { get; set; }

        [Display(Name ="Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail Adresi Giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

    }
}
