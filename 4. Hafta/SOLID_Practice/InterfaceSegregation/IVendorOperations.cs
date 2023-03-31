namespace InterfaceSegregation
{
    internal interface IVendorOperations : ISaleReport
    {
        void AddProduct();
        void RemoveProduct();
        void ManageOrders();
    }
}
