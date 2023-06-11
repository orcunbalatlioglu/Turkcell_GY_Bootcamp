using System.ComponentModel.DataAnnotations;

namespace KidegaClone.MVC.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Email boş olamaz")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
