using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class UpdateOrderRequest
    {
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required(ErrorMessage = "Kullanıcı id boş geçilemez.")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Sipariş içerisinde kitap olmalı.")]
        public ICollection<BookOrder> Books { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required(ErrorMessage = "Adres id boş olamaz.")]
        public int AddressID { get; set; }
        public int TotalPrice { get; set; }
        public bool? IsSuccesfullyPaid { get; set; }
    }
}
