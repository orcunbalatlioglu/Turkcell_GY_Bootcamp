using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<BookCategory>? Books { get; set;}
    }
}
