namespace SingleResponsibility
{
    public class Order
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public int Balance { get; set; }

        public Order(List<Item> cart)
        {
            Id = IdGenerator.NextId();
            Items = new List<Item>(cart);
            foreach (var item in Items)
            {
                Balance += item.Price * item.Amount;
            }
        }
    }
}
