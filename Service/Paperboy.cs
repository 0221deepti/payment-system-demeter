using System;
using PaymentSystem.Interfaces;

namespace PaymentSystem.Services
{
    public class Paperboy
    {
        public void CollectPayment(IPayable customer, decimal amount)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            if (!customer.Pay(amount))
            {
                Console.WriteLine("Customer could not pay. Come back later.");
            }
            else
            {
                Console.WriteLine("Payment collected successfully.");
            }
        }
    }
}