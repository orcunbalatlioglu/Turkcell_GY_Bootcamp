using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class OrderListItem
    {
        public DisplayOrderResponse OrderResponse { get; set; }
        public DisplayAddressResponse AddressResponse { get; set; }
    }
}
