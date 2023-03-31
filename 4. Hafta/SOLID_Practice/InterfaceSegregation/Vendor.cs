namespace InterfaceSegregation
{
    internal class Vendor : IProfileOperations, IVendorOperations
    {
        public string UserName => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public void AddProduct()
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

        public void ManageOrders()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct()
        {
            throw new NotImplementedException();
        }

        public void ViewProfile()
        {
            throw new NotImplementedException();
        }

        public void ViewSaleReport()
        {
            throw new NotImplementedException();
        }
    }
}
