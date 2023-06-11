using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class UpdateAddressRequest
    {
        public int Id { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage ="Şehir boş bırakılamaz.")]
        public string City { get; set; }
        [Required(ErrorMessage = "İlçe boş bırakılamaz.")]
        public string District { get; set; }
        [Required(ErrorMessage = "Mahalle boş bırakılamaz.")]
        public string Neighbourhood { get; set; }
        [Required(ErrorMessage = "Sokak boş bırakılamaz.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Bina no boş bırakılamaz.")]
        public string BuildingNo { get; set; }
        [Required(ErrorMessage = "Daire no boş bırakılamaz.")]
        public int FlatNo { get; set; }
    }
}
