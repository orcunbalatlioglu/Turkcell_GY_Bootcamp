using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Models
{
    public class UserOperationViewModel
    {
        public IEnumerable<DisplayUserResponse>? UserList { get; set; }
    }
}
