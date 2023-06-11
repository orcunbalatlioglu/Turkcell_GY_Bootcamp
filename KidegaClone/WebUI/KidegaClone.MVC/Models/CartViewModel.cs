using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class CartViewModel
    {
        public CartContent Cart { get; set; }
        public IEnumerable<DisplayAddressResponse> Address { get; set; }
        public DisplayUserResponse CartUser { get; set; }
        public int selectedAddressId { get; set; }
        public decimal TotalCartPrice { get; set; }
    }
}
