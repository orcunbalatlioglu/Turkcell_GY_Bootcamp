using KidegaClone.Domain.Entities;

namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayBookResponse
    {
        public int Id { get; set; }
        public string? Picture { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ShortExcerpt { get; set; }
        public decimal Price { get; set; }
        public decimal? Rating { get; set; }
        public long? Barcode { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? PageNumber { get; set; }
        public bool IsHardCover { get; set; }
        public int PublisherID { get; set; }
        public int AuthorID { get; set; }
    }
}
