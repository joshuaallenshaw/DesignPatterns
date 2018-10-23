/* GoF Builder Pattern
 * Separate the construction of a complex object from its representation so that the same construction processes can create different representations.
 */

using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ExecuteSimpleInterfaceExample();
            ExecuteFluentAbstractExample();
            Console.ReadLine();

            void ExecuteSimpleInterfaceExample()
            {
                var cook = new SimpleInterface.Cook();

                SimpleInterface.IPizzaBuilder hawaiianPizzaBuilder = new SimpleInterface.HawaiianPizzaBuilder();
                cook.SetPizzaBuilder(hawaiianPizzaBuilder);
                cook.ConstructPizza();

                // get the product
                var hawaiian = hawaiianPizzaBuilder.GetPizza();
                Console.WriteLine("Pizza Dough: {0}", hawaiian.Dough);
                Console.WriteLine("Pizza Sauce: {0}", hawaiian.Sauce);
                Console.WriteLine("Pizza Topping: {0}", String.Join(", ", hawaiian.Toppings.ToArray()));

                Console.WriteLine("\n");

                SimpleInterface.IPizzaBuilder spicyPizzaBuilder = new SimpleInterface.SpicyPizzaBuilder();
                cook.SetPizzaBuilder(spicyPizzaBuilder);
                cook.ConstructPizza();
                // get another product
                var spicy = spicyPizzaBuilder.GetPizza();
                Console.WriteLine("Pizza Dough: {0}", spicy.Dough);
                Console.WriteLine("Pizza Sauce: {0}", spicy.Sauce);
                Console.WriteLine("Pizza Topping: {0}", String.Join(", ", spicy.Toppings.ToArray()));
            }
            void ExecuteFluentAbstractExample()
            {
                Console.WriteLine("\n");
                FluentAbstract.PizzaBuilder hawaiianPizzaBuilder = new FluentAbstract.HawaiianPizzaBuilder();
                // Fluent Cook format makes this easier
                var cook = new FluentAbstract.Cook()
                    .SetPizzaBuilder(hawaiianPizzaBuilder)
                    .ConstructPizza();

                // get the product
                var hawaiian = hawaiianPizzaBuilder.GetPizza();
                Console.WriteLine("Pizza Dough: {0}", hawaiian.Dough);
                Console.WriteLine("Pizza Sauce: {0}", hawaiian.Sauce);
                Console.WriteLine("Pizza Topping: {0}", String.Join(", ", hawaiian.Toppings.ToArray()));

                Console.WriteLine("\n");

                FluentAbstract.PizzaBuilder spicyPizzaBuilder = new FluentAbstract.SpicyPizzaBuilder();
                cook.SetPizzaBuilder(spicyPizzaBuilder);
                cook.ConstructPizza();
                // create another product
                var spicy = spicyPizzaBuilder.GetPizza();
                Console.WriteLine("Pizza Dough: {0}", spicy.Dough);
                Console.WriteLine("Pizza Sauce: {0}", spicy.Sauce);
                Console.WriteLine("Pizza Topping: {0}", String.Join(", ", spicy.Toppings.ToArray()));
            }
        }
    }
}