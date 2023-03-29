using System.ComponentModel.DataAnnotations;

namespace OpenClosedPrinciple
{

    internal class EmailSender
    {
        private IEmailType emailType{ get; set; }
        private string emailAddress { get; set; }

        public EmailSender(): this("abcdef",new Gmail()){ }

        public EmailSender(string address):this(address,new Gmail()){ }

        public EmailSender(IEmailType type) : this("abcdef", type) { }

        public EmailSender(string address,IEmailType type)
        {
            emailType = type;
            emailAddress = emailType.MailFormat(address);
        }

        public bool SendEmail()
        {
            return true;
        }
    }
}
