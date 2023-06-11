using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class CartContent
    {
        public List<CartItem> Content { get; set; } = new List<CartItem>();

        public void ClearAll() => Content.Clear();
        public decimal TotalBookPrice() => Content.Sum(item => (decimal)item.Book.Price * item.Quantity);
        public int TotalContentCount() => Content.Sum(p => p.Quantity);
        public IEnumerable<DisplayBookResponse> GetAllBooks()
        {
            List<DisplayBookResponse> displayBooks = new List<DisplayBookResponse>();
            foreach (var item in Content)
            {
                displayBooks.Add(item.Book);
            }
            return displayBooks;
        }
        public void AddNewBook(CartItem cartItem)
        {
            var exists = Content.FirstOrDefault(c => c.Book.Id == cartItem.Book.Id);
            if (exists != null)
            {
                exists.Quantity += cartItem.Quantity;
            }
            else
            {
                Content.Add(cartItem);
            }
        }
    }
}
