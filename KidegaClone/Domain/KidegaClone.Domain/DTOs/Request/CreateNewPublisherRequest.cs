using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewPublisherRequest
    {
        [Required(ErrorMessage = "İsim boş bırakılamaz.")]
        public string Name { get; set; }
        public string? Picture { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
