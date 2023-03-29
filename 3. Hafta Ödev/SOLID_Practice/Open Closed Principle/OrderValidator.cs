namespace OpenClosedPrinciple
{
    internal class OrderValidator
    {
        public Order Order { get; set;}

        public OrderValidator(Order order)
        {
            Order = order;
        }

        public bool ValidateBalance() => Order.Balance > 500;

        public bool ValidateAmount() { 
            foreach (var item in Order.Items)
            {
                if(item.Amount > 10)
                    return false;
            }
            return true;
        }
    }
}
