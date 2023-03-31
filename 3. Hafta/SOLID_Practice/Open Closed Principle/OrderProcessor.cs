using System.Xml.Linq;

namespace OpenClosedPrinciple
{
    public class OrderProcessor
    {   
        public bool IsOrderValid { get; set; }
        public bool IsPaymentCompleted { get; set; }
        public bool IsEmailSent { get; set; }
        Order Order { get; set; }
        OrderValidator Validator { get; set; }
        IPaymentProcessor _PaymentProcessor { get; set; }
        EmailSender emailSender { get; set; }

        public OrderProcessor(Order order)
        {
            Order = order;
        }


        public string ValidateOrder()
        {
            Validator = new OrderValidator(Order);
            if (!Validator.ValidateBalance())
            { 
                IsOrderValid = false;
                return "Your order could not be fulfilled due to invalid price!\nA single order must not exceed 500 TL.";
            }

            if (!Validator.ValidateAmount()) {
                IsOrderValid = false; 
                return "Your order could not be fulfilled due to invalid product quantity!\nA maximum of 10 items can be added from a single product.";
            }
                
            IsOrderValid = true;
            return "Your order has been successfully created.";
        }


        public string ProcessPayment(string name,string number,int month,int year,int cv2) 
        {
            IsPaymentCompleted = false;
            CreditCard card = new CreditCard(name, number, month, year, cv2);
            _PaymentProcessor = new CreditCardPaymentProcessor(card);
            Tuple<bool,string> result = _PaymentProcessor.ProcessPayment();
            IsPaymentCompleted = result.Item1;

            return result.Item2;
        }

        public string ProcessPayment()
        {
            IsPaymentCompleted = false;
            _PaymentProcessor = new CashPaymentProcessor();
            Tuple<bool, string> result = _PaymentProcessor.ProcessPayment();
            IsPaymentCompleted = result.Item1;

            return result.Item2;
        }

        public string ProcessPayment(int point)
        {
            IsPaymentCompleted = false;
            //In here there can be check of points in feature, if user class implemented.
            _PaymentProcessor = new PointPaymentProcessor();
            Tuple<bool, string> result = _PaymentProcessor.ProcessPayment();
            IsPaymentCompleted = result.Item1;

            return result.Item2;
        }


        public string SendEmail()
        {
            emailSender = new EmailSender();
            if (emailSender.SendEmail())
                return "Your order archive has been sent to your registered e-mail address.";
            return "Your order information could not be sent to your e-mail.\nPlease check your informations.";
        }

        public string SendEmail(string address)
        {
            emailSender = new EmailSender(address);
            if (emailSender.SendEmail())
                return "Your order archive has been sent to your registered e-mail address.";
            return "Your order information could not be sent to your e-mail.\nPlease check your informations.";
        }

        public string SendEmail(IEmailType type)
        {
            emailSender = new EmailSender(type);
            if (emailSender.SendEmail())
                return "Your order archive has been sent to your registered e-mail address.";
            return "Your order information could not be sent to your e-mail.\nPlease check your informations.";
        }

        public string SendEmail(string address,IEmailType type)
        {
            emailSender = new EmailSender(address, type);
            if (emailSender.SendEmail())
                return "Your order archive has been sent to your registered e-mail address.";
            return "Your order information could not be sent to your e-mail.\nPlease check your informations.";
        }


    }
}
