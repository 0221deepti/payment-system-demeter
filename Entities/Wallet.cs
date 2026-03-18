namespace PaymentSystem.Entities
{
    public class Wallet
    {
        private decimal _balance;

        public Wallet(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public bool HasSufficientFunds(decimal amount)
        {
            return _balance >= amount;
        }

        public void Debit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive");

            if (!HasSufficientFunds(amount))
                throw new InvalidOperationException("Insufficient funds");

            _balance -= amount;
        }
    }
}