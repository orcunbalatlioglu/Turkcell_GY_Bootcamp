using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class AuthorDetailViewModel
    {
        public DisplayAuthorResponse Author { get; set; }
        public IEnumerable<BookComponentInfo>? BooksOfAuthor { get; set; } 
    }
}
