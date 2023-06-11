using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Request
{
    public class CreateNewOrderRequest
    {
        [Required]
        public User User { get; set; }
        [Required(ErrorMessage = "Kullanıcı id boş olamaz.")]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Siparişte içerisinde kitap olmalı.")]
        public ICollection<BookOrder> Books { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required(ErrorMessage = "Adres id boş olamaz.")]
        public int AddressID { get; set; }
        public decimal TotalPrice { get; set; }
        public bool? IsSuccesfullyPaid { get; set; } = false;
    }
}
