namespace SingleResponsibility
{
    internal class EmailSender
    {
        private string emailAddress { get; set; }
        public EmailSender(string email)
        {
            emailAddress = email;
        }

        public bool SendEmail()
        {
            return true;
        }
    }
}
