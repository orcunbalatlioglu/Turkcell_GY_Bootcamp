using KidegaClone.Domain.Entities;

namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayOrderResponse
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int AddressID { get; set; }
        public int TotalPrice { get; set; }
        public bool IsSuccesfullyPaid { get; set; }
    }
}
