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
        [Required]
        [MinLength(8, ErrorMessage = "En az 8 karakter!")]
        public string Password { get; set; }
        [Required]
        public Role Role { get; set; }
        public string? PhoneNumber { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
