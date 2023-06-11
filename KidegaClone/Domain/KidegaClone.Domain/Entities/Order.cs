using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public ICollection<BookOrder> Books { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public int AddressID { get; set; }
        public decimal TotalPrice { get; set; }
        public bool? IsSuccesfullyPaid { get; set; } = false;
        
    }
}
