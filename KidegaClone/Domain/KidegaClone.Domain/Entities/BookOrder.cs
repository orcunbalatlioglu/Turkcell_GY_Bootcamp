namespace KidegaClone.Domain.Entities
{
    public class BookOrder
    {
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
