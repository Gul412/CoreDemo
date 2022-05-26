using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Şifrenizi Giriniz")]
        public string password { get; set; }



    }
}
