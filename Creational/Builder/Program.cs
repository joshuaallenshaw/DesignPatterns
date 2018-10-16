using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cook = new Cook();

            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            cook.SetPizzaBuilder(hawaiianPizzaBuilder);
            cook.ConstructPizza();
            // create the product
            var hawaiian = hawaiianPizzaBuilder.GetPizza();
            Console.WriteLine("Pizza Dough: {0}", hawaiian.Dough);
            Console.WriteLine("Pizza Sauce: {0}", hawaiian.Sauce);
            Console.WriteLine("Pizza Topping: {0}", String.Join(", ", hawaiian.Toppings.ToArray()));

            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            cook.SetPizzaBuilder(spicyPizzaBuilder);
            cook.ConstructPizza();
            // create another product
            var spicy = spicyPizzaBuilder.GetPizza();
            Console.WriteLine("Pizza Dough: {0}", spicy.Dough);
            Console.WriteLine("Pizza Sauce: {0}", spicy.Sauce);
            Console.WriteLine("Pizza Topping: {0}", String.Join(", ", spicy.Toppings.ToArray()));

            Console.ReadLine();
        }
    }
}