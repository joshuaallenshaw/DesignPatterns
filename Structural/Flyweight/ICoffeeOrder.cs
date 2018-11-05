namespace Flyweight
{
    /// <summary>
    /// The Flyweight Interface
    /// </summary>
    public interface ICoffeeOrder
    {
        void ServeCoffee(CoffeeOrderContext context);
    }
}