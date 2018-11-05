/* GoF Flyweight Pattern
 * Use sharing to support large numbers of fine-grained objects efficiently. A flyweight is a shared object
 * that can be used in multiple contexts simultaneously. The flyweight acts as an independent object in each
 * context; it’s indistinguishable from an instance of the object that’s not shared.
 */

using System;

namespace Flyweight
{
    internal class Program
    {
        private static readonly CoffeeFlavor[] Flavors = new CoffeeFlavor[100];
        private static readonly CoffeeOrderContext[] Tables = new CoffeeOrderContext[100];

        private static CoffeeFlavorFactory factory;
        private static int ordersMade;

        private static void Main(string[] args)
        {
            factory = new CoffeeFlavorFactory();

            TakeOrder("Cappuccino", 2);
            TakeOrder("Cappuccino", 2);
            TakeOrder("Frappe", 1);
            TakeOrder("Frappe", 1);
            TakeOrder("Xpresso", 1);
            TakeOrder("Frappe", 897);
            TakeOrder("Cappuccino", 97);
            TakeOrder("Cappuccino", 97);
            TakeOrder("Frappe", 3);
            TakeOrder("Xpresso", 3);
            TakeOrder("Cappuccino", 3);
            TakeOrder("Xpresso", 96);
            TakeOrder("Frappe", 552);
            TakeOrder("Cappuccino", 121);
            TakeOrder("Xpresso", 121);

            for (int i = 0; i < ordersMade; i++)
            {
                Flavors[i].ServeCoffee(Tables[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Total CoffeeFlavor objects made {0}", factory.TotalFlaversMade);
            Console.ReadKey();
        }

        private static void TakeOrder(string flaver, int table)
        {
            Flavors[ordersMade] = factory.GetCoffeeFlavor(flaver);
            Tables[ordersMade++] = new CoffeeOrderContext(table);
        }
    }
}