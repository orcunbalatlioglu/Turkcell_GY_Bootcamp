namespace SingleResponsibility
{
    internal class PaymentProcessor
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

        public PaymentProcessor(string _name, string _number, int _month, int _year, int _cv2)
        {
            Name = _name;
            CardNumber = _number;
            Month = _month;
            Year = _year;
            Cv2 = _cv2;
        }
        public void ProcessPayment()
        {
            if (!validateName())
                return;
            else if (!validateNumber())
                return;
            else if (!validateDate())
                return;
            else if (!validateCV2())
                return;
            //Process the payment
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
}
