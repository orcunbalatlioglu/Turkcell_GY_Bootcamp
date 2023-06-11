using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class CartViewModel
    {
        public CartContent Cart { get; set; }
        public IEnumerable<DisplayAddressResponse> Address { get; set; }
        public DisplayUserResponse User { get; set; }
    }
}
