namespace InterfaceSegregation
{
    internal class Administrator : IProfileOperations, IAdministratorOperations
    {
        public string UserName => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public void ChangePassword(string password)
        {
            throw new NotImplementedException();
        }

        public void ChangeUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public void ManageRoles()
        {
            throw new NotImplementedException();
        }

        public void ManageUsers()
        {
            throw new NotImplementedException();
        }

        public void ManegeRolesForUser(string username)
        {
            throw new NotImplementedException();
        }

        public void UpdateSettings()
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
