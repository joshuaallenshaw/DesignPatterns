using System;

namespace Flyweight
{
    /// <summary>
    /// The Concrete Flyweight Class
    /// </summary>
    public class CoffeeFlavor : ICoffeeOrder
    {
        public CoffeeFlavor(string newFlavor)
        {
            Flavor = newFlavor;
        }

        public string Flavor { get; private set; }

        public void ServeCoffee(CoffeeOrderContext context)
        {
            Console.WriteLine("Serving coffee flavor {0} to table {1} .", Flavor, context.Table);
        }
    }
}