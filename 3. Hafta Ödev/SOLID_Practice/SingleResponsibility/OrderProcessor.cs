namespace SingleResponsibility
{
    public class OrderProcessor
    {   
        public bool IsValid { get; set; }
        public bool IsPaymentCompleted { get; set; }
        public bool IsEmailSent { get; set; }
        public string Email { get; set; }
        Order Order { get; set; }
        OrderValidator Validator { get; set; }
        PaymentProcessor _PaymentProcessor { get; set; }
        EmailSender emailSender { get; set; }

        public OrderProcessor(Order order)
        {
            Order = order;
            Email = "abcdef@gmail.com";
        }
        public string ValidateOrder()
        {
            Validator = new OrderValidator(Order);
            if (!Validator.ValidateBalance())
            { 
                IsValid = false;
                return "Siparişiniz geçersiz fiyat sebebi ile gerçekleştirilememiştir!\nTek bir siparişin 500 TL üzerinde olmaması gerekmektedir.";
            }

            if (!Validator.ValidateAmount()) {
                IsValid = false; 
                return "Siparişiniz geçersiz ürün miktarı sebebi ile gerçekleştirilememiştir!\nTek bir üründen en fazla 10 adet eklenebilmektedir.";
            }
                
            IsValid = true;
            return "Siparişiniz başarılı bir şekilde oluşturulmuştur.";
        }

        public string ProcessPayment(string name,string number,int month,int year,int cv2) 
        {
            IsPaymentCompleted = false;
            _PaymentProcessor = new PaymentProcessor(name,number,month,year,cv2);
            _PaymentProcessor.ProcessPayment();

            if (!_PaymentProcessor.IsNameValid)
                return "Ödemeniz başarısız olmuştur!\nGirdiğiniz isim geçersiz.";
            else if (!_PaymentProcessor.IsCreditCardNumberValid)
                return "Ödemeniz başarısız olmuştur!\nGirdiğiniz kart numarası geçersiz.";
            else if (!_PaymentProcessor.IsDateValid)
                return "Ödemeniz başarısız olmuştur!\nGirdiğiniz kart son kullanma tarihi geçersiz.";
            else if (!_PaymentProcessor.IsCv2Valid)
                return "Ödemeniz başarısız olmuştur!\nGirdiğiniz CV2 numarası geçersiz.";

            IsPaymentCompleted = true;
            return "Ödemeniz başarılı şekilde tamamlanmıştır.";
        }
        
        public string SendEmail()
        {
            emailSender = new EmailSender(Email);
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
        

    }
}
