using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewCategoryRequest
    {
        [Required(ErrorMessage ="İsim boş bırakılamaz.")]
        public string Name { get; set; }
        public ICollection<BookCategory>? Books { get; set; }
    }
}
