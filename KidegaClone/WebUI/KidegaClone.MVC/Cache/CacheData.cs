using KidegaClone.Domain.DTOs.Response;

namespace KidegaClone.MVC.Cache
{
    public class CacheData
    {
        public IEnumerable<DisplayBookResponse> Books { get; set; }
        public DateTime CacheTime { get; set; }
    }
}
