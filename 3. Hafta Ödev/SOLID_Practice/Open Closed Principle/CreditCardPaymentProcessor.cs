namespace OpenClosedPrinciple
{
    internal class CreditCardPaymentProcessor : IPaymentProcessor
    {
        private string Name { get; set; }
        private string CardNumber { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }
        private int Cv2 { get; set; }
        public bool IsNameValid { get; set; }
        public bool IsCreditCardNumberValid { get; set; }
        public bool IsDateValid { get; set; }
        public bool IsCv2Valid { get; set; }

        public CreditCardPaymentProcessor(string _name, string _number, int _month, int _year, int _cv2)
        {
            Name = _name;
            CardNumber = _number;
            Month = _month;
            Year = _year;
            Cv2 = _cv2;
        }
        public Tuple<bool,string> ProcessPayment()
        {
            if (!validateName())
                return Tuple.Create(false, "Ödemeniz başarısız olmuştur!\nGirdiğiniz isim geçersiz.");
            else if (!validateNumber())
                return Tuple.Create(false, "Ödemeniz başarısız olmuştur!\nGirdiğiniz kart numarası geçersiz.");
            else if (!validateDate())
                return Tuple.Create(false, "Ödemeniz başarısız olmuştur!\nGirdiğiniz kart son kullanma tarihi geçersiz.");
            else if (!validateCV2())
                return Tuple.Create(false, "Ödemeniz başarısız olmuştur!\nGirdiğiniz CV2 numarası geçersiz.");
            //Process the payment
            return Tuple.Create(true,"Ödemeniz başarılı şekilde tamamlanmıştır.");
        }
        private bool validateName()
        {
            if (Name == "" || !Name.Contains(" ")) {
                IsNameValid = false;
                return false;
            }
                
            IsNameValid = true;
            return true;
        }
        private bool validateNumber()
        {
            CardNumber = CardNumber.Replace(" ", "");
            if (CardNumber == null || CardNumber.Length < 16) {
                IsCreditCardNumberValid = false;
                return false;
            }
            IsCreditCardNumberValid = true;
            return true;
        }
        private bool validateDate()
        {
            IsDateValid = true;
            return true;
        }
        private bool validateCV2()
        {
            if (Cv2.ToString().Length < 3)
            {
                IsCv2Valid = false;
                return false;
            }
            IsCv2Valid = true;
            return true;
        }

    }

    internal class CashPaymentProcessor : IPaymentProcessor
    {
        public Tuple<bool, string> ProcessPayment()
        {
            return Tuple.Create(true, "Ödemeniz başarılı şekilde tamamlanmıştır.");
        }
    }

    internal class PointPaymentProcessor : IPaymentProcessor
    {
        public Tuple<bool, string> ProcessPayment()
        {
            return Tuple.Create(true, "Ödemeniz başarılı şekilde tamamlanmıştır.");
        }
    }
}
