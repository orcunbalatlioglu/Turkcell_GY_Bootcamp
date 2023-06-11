using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class CartItem
    {
        public DisplayBookResponse Book { get; set; }
        public int Quantity { get; set; }
    }
}
