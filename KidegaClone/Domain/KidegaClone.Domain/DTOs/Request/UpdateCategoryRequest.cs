using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim boş bırakılamaz.")]
        public string Name { get; set; }
        public ICollection<BookCategory>? Books { get; set; }
    }
}
