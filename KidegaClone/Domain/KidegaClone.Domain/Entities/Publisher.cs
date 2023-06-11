using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Publisher: IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Picture { get; set; }
        public ICollection<Book>? Books { get; set;}
    }
}
