namespace InterfaceSegregation
{
    internal interface IProfileOperations
    {
        string UserName { get; }
        string Password { get; }

        void ViewProfile();
        void ChangeUserName(string userName);
        void ChangePassword(string password);
    }
}
