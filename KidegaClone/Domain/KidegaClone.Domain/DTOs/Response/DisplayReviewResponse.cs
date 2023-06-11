using KidegaClone.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayReviewResponse
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
    }
}
