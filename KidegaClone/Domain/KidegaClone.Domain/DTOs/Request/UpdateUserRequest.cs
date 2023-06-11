using KidegaClone.Domain.Entities;
using KidegaClone.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim boş bırakılamaz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "E-posta adresi boş bırakılamaz.")]
        [EmailAddress(ErrorMessage ="Geçerli bir e-posta adresi giriniz!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş bırakılamaz!")]
        [MinLength(8, ErrorMessage = "En az 8 karakter!")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Rol boş bırakılamaz!")]
        public Role Role { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
