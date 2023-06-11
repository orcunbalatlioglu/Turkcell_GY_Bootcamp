namespace KidegaClone.MVC.Models
{
    public class BookComponentInfo
    {
        public int Id { get; set; }
        public string? Picture { get; set; }
        public string Name { get; set; }
        public string PublisherName { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public decimal? Rating { get; set;}
    }
}
