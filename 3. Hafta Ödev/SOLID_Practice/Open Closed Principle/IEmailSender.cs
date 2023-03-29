namespace OpenClosedPrinciple
{
    public interface IEmailType
    {
        string MailFormat(string address);
    }

    public class Gmail : IEmailType
    {
        public string MailFormat(string address)
        {
            return address + "@gmail.com"; 
        }
    }
    public class Outlook : IEmailType
    {
        public string MailFormat(string address)
        {
            return address + "@outlook.com";
        }
    }
    public class Ogu : IEmailType
    {
        public string MailFormat(string address)
        {
            return address + "@ogu.edu.tr";
        }
    }
}
