using PaymentSystem.Entities;
using PaymentSystem.Services;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var wallet = new Wallet(100);
            var customer = new Customer("John", "Doe", wallet);
            var paperboy = new Paperboy();

            paperboy.CollectPayment(customer, 50);
        }
    }
}