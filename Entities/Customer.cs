using PaymentSystem.Interfaces;

namespace PaymentSystem.Entities
{
    public class Customer : IPayable
    {
        public string FirstName { get; }
        public string LastName { get; }

        private readonly Wallet _wallet;

        public Customer(string firstName, string lastName, Wallet wallet)
        {
            FirstName = firstName;
            LastName = lastName;
            _wallet = wallet ?? throw new ArgumentNullException(nameof(wallet));
        }

        public bool Pay(decimal amount)
        {
            if (!_wallet.HasSufficientFunds(amount))
            {
                return false;
            }

            _wallet.Debit(amount);
            return true;
        }
    }
}