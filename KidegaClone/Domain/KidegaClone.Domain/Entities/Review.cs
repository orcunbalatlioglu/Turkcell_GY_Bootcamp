using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Review : IEntity
    {
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public Book Book { get; set; }
        [Required]
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
