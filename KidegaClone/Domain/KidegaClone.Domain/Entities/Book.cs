using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Author Author { get; set; }
        [Required]
        public int AuthorID { get; set; }
        [Required]
        public ICollection<BookCategory> Categories { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ICollection<BookOrder>? Orders { get; set; }
        [Required]
        public Publisher Publisher { get; set; }
        [Required]
        public int PublisherID { get; set; }
        public DateTime? PublishDate { get; set; }
        public decimal? Rating { get; set; }
        public string? Picture { get; set; }
        public string? Description { get; set; }
        public string? ShortExcerpt { get; set; }
        public bool IsHardcover { get; set; }
        public short? PageNumber { get; set; } 
        public short? Width { get; set; }
        public short? Height { get; set; }
        public long? Barcode { get; set; }
        public ICollection<Review>? Reviews { get; set; }

    }
}
