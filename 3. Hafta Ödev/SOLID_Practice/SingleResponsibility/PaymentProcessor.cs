namespace SingleResponsibility
{
    internal class PaymentProcessor
    {
        private string name { get; set; }
        private string cardNumber { get; set; }
        private int month { get; set; }
        private int year { get; set; }
        private int cv2 { get; set; }
        public bool IsNameValid { get; set; }
        public bool IsCreditCardNumberValid { get; set; }
        public bool IsDateValid { get; set; }
        public bool IsCv2Valid { get; set; }

        public PaymentProcessor(string _name, string number, int _month, int _year, int _cv2)
        {
            name = _name;
            cardNumber = number;
            month = _month;
            year = _year;
            cv2 = _cv2;
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
            if (name == "" || !name.Contains(" ")) {
                IsNameValid = false;
                return false;
            }
                
            IsNameValid = true;
            return true;
        }
        private bool validateNumber()
        {
            cardNumber = cardNumber.Replace(" ", "");
            if (cardNumber == null || cardNumber.Length < 16) {
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
            if (cv2.ToString().Length < 3)
            {
                IsCv2Valid = false;
                return false;
            }
            IsCv2Valid = true;
            return true;
        }

    }
}
