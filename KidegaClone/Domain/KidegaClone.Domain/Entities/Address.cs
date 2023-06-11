using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.Entities
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public string? Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string Neighbourhood { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string BuildingNo { get; set; }
        [Required]
        public int FlatNo { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public int UserID { get; set; }
    }
}
