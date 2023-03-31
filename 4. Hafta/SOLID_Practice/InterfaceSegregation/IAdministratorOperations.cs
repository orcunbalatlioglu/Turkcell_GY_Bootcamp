namespace InterfaceSegregation
{
    internal interface IAdministratorOperations: ISaleReport
    {
        void ManageUsers();
        void ManageRoles();
        void ManegeRolesForUser(string username);
        void UpdateSettings();
    }
}
