namespace Flyweight
{
    /// <summary>
    /// The Flyweight client.
    /// </summary>
    public class CoffeeOrderContext
    {
        public CoffeeOrderContext(int tableNumber)
        {
            Table = tableNumber;
        }

        public int Table { get; private set; }
    }
}