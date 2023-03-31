namespace OOPRealLifeExamples
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {

        }
    }

    public class BankTransferPayment : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {

        }
    }

    public class PaymentProcessor
    {
        private IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void MakePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }

}
