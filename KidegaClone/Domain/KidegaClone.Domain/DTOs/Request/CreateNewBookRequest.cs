using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewBookRequest
    {
        [Required(ErrorMessage ="İsim boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Yazar boş bırakılamaz")]
        public Author Author { get; set; }
        [Required(ErrorMessage = "Yazar id boş bırakılamaz")]
        public int AuthorID { get; set; }
        [Required(ErrorMessage = "Kategoriler boş bırakılamaz")]
        public ICollection<BookCategory> Categories { get; set; }
        [Required(ErrorMessage = "Fiyat boş bırakılamaz")]
        public decimal Price { get; set; }        
        [Required(ErrorMessage = "Yayıncı boş bırakılamaz")]
        public Publisher Publisher { get; set; }
        [Required(ErrorMessage = "Yayıncı id boş bırakılamaz")]
        public int PublisherID { get; set; }
        public ICollection<BookOrder>? Orders { get; set; }
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
