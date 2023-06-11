using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class BookDetailViewModel
    {
        public DisplayBookResponse Book { get; set; }
        public DisplayAuthorResponse Author { get; set; }
    }
}
