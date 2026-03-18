namespace PaymentSystem.Interfaces
{
    public interface IPayable
    {
        bool Pay(decimal amount);
    }
}