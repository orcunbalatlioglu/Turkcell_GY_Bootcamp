using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewAuthorRequest
    {
        [Required(ErrorMessage ="Yazar adı boş bırakılamaz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yazar soyadı boş bırakılamaz.")]
        public string Surname { get; set; }
        public string? Biography { get; set; }
        public string? Picture { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
