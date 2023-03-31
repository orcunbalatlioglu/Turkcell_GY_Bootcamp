namespace OOPRealLifeExamples
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                balance -= amount;
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
