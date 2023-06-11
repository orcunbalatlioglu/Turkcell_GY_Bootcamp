using KidegaClone.Domain.Entities;
using KidegaClone.Domain.Enums;

namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayUserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
