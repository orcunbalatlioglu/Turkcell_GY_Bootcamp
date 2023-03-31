namespace OpenClosedPrinciple
{
    internal class CreditCardPaymentProcessor : IPaymentProcessor
    {
        CreditCard CreditCard { get; set; }
        public bool IsNameValid { get; set; }
        public bool IsCreditCardNumberValid { get; set; }
        public bool IsDateValid { get; set; }
        public bool IsCv2Valid { get; set; }

        public CreditCardPaymentProcessor(CreditCard card) 
        { 
            CreditCard = card;
        }

        public Tuple<bool,string> ProcessPayment()
        {
            if (!validateName())
                return Tuple.Create(false, "Your payment failed!\nThe name you entered is invalid.");
            else if (!validateNumber())
                return Tuple.Create(false, "Your payment failed!\nThe number of credit card you entered is invalid.");
            else if (!validateDate())
                return Tuple.Create(false, "Your payment failed!\nThe expiry date of the card you entered is invalid.");
            else if (!validateCV2())
                return Tuple.Create(false, "Your payment failed!\nThe cv2 of the card you entered is invalid.");
            //Process the payment
            return Tuple.Create(true, "Your payment has been successfully completed.");
        }
        private bool validateName()
        {
            if (CreditCard.Name == "" || !CreditCard.Name.Contains(" ")) {
                IsNameValid = false;
                return false;
            }
                
            IsNameValid = true;
            return true;
        }
        private bool validateNumber()
        {
            string cardNumber = CreditCard.CardNumber.Replace(" ", "");
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
            if (CreditCard.Cv2.ToString().Length < 3)
            {
                IsCv2Valid = false;
                return false;
            }
            IsCv2Valid = true;
            return true;
        }

    }
}
