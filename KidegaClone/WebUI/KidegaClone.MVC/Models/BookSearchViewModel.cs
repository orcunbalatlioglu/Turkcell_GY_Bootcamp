using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class BookSearchViewModel
    {
        public IEnumerable<DisplayCategoryResponse> Categories { get; set; }
        public IEnumerable<BookComponentInfo> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
    }
}
