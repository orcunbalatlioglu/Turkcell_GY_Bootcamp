namespace SingleResponsibility
{
    internal class OrderValidator
    {
        public Order Order { get; set;}

        public OrderValidator(Order order)
        {
            Order = order;
        }

        public bool ValidateBalance()
        {
            if(Order.Balance > 500)
                return false;
            return true;
        }
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
