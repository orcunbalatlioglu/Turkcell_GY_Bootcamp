using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewReviewRequest
    {
        [Required]
        public User User { get; set; }
        [Required(ErrorMessage = "Kullanıcı id boş bırakılamaz.")]
        public int UserID { get; set; }
        [Required]
        public Book Book { get; set; }
        [Required(ErrorMessage = "Kitap id boş bırakılamaz.")]
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        [Required(ErrorMessage = "Derecelendirme puanı boş bırakılamaz.")]
        public int Rating { get; set; }
    }
}
