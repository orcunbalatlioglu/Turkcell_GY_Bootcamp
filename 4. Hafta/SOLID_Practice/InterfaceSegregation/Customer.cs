namespace InterfaceSegregation
{
    internal class Customer : IProfileOperations, ICustomerOperations
    {
        public string UserName => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public void AddToCart()
        {
            throw new NotImplementedException();
        }

        public void BrowseProducts()
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string password)
        {
            throw new NotImplementedException();
        }

        public void ChangeUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart()
        {
            throw new NotImplementedException();
        }

        public void ViewProfile()
        {
            throw new NotImplementedException();
        }
    }
}
