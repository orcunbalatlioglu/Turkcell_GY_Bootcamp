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
                return "Siparişiniz geçersiz fiyat sebebi ile gerçekleştirilememiştir!\nTek bir siparişin 500 TL üzerinde olmaması gerekmektedir.";
            }

            if (!Validator.ValidateAmount()) {
                IsOrderValid = false; 
                return "Siparişiniz geçersiz ürün miktarı sebebi ile gerçekleştirilememiştir!\nTek bir üründen en fazla 10 adet eklenebilmektedir.";
            }
                
            IsOrderValid = true;
            return "Siparişiniz başarılı bir şekilde oluşturulmuştur.";
        }


        public string ProcessPayment(string name,string number,int month,int year,int cv2) 
        {
            IsPaymentCompleted = false;
            _PaymentProcessor = new CreditCardPaymentProcessor(name,number,month,year,cv2);
            Tuple<bool,string> result = _PaymentProcessor.ProcessPayment();
            IsPaymentCompleted = result.Item1;

            return result.Item2;
        }
        

        public string SendEmail()
        {
            emailSender = new EmailSender();
            if (emailSender.SendEmail())
                return "Kayıtlı mail adresinize sipariş bilgileriniz gönderilmiştir.";
            return "Sipariş bilgileriniz mailinize gönderilememiştir\nLütfen bilgilerinizi kontrol ediniz.";
        }

        public string SendEmail(string address)
        {
            emailSender = new EmailSender(address);
            if (emailSender.SendEmail())
                return "Kayıtlı mail adresinize sipariş bilgileriniz gönderilmiştir.";
            return "Sipariş bilgileriniz mailinize gönderilememiştir\nLütfen bilgilerinizi kontrol ediniz.";
        }

        public string SendEmail(IEmailType type)
        {
            emailSender = new EmailSender(type);
            if (emailSender.SendEmail())
                return "Kayıtlı mail adresinize sipariş bilgileriniz gönderilmiştir.";
            return "Sipariş bilgileriniz mailinize gönderilememiştir\nLütfen bilgilerinizi kontrol ediniz.";
        }

        public string SendEmail(string address,IEmailType type)
        {
            emailSender = new EmailSender(address, type);
            if (emailSender.SendEmail())
                return "Kayıtlı mail adresinize sipariş bilgileriniz gönderilmiştir.";
            return "Sipariş bilgileriniz mailinize gönderilememiştir\nLütfen bilgilerinizi kontrol ediniz.";
        }


    }
}
