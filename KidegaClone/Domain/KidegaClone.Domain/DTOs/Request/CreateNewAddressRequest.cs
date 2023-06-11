using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewAddressRequest
    {
        public string? Name { get; set; } = "Adres";
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
        [Required(ErrorMessage = "Kullanıcı boş bırakılamaz.")]
        public User User { get; set; }
        [Required(ErrorMessage = "Kullanıcı id boş bırakılamaz.")]
        public int UserID { get; set; }
    }
}
