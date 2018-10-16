using System;
using System.Collections.Generic;

namespace Builder.SimpleInterface
{
    /// <summary>
    /// A Concrete Builder Class
    /// </summary>
    internal class SpicyPizzaBuilder : IPizzaBuilder
    {
        protected Pizza Pizza;
        protected List<string> Toppings = new List<string>();

        public SpicyPizzaBuilder()
        {
            Pizza = new Pizza();
            SelectTopping("Mozzarella Cheese");
            SelectTopping("Pepperoni");
            SelectTopping("Salami");
        }

        public void AddSauce()
        {
            Pizza.Sauce = "Hot";
        }

        public void AddToppings()
        {
            Pizza.Toppings = Toppings;
        }

        public void BakePizza()
        {
            Console.WriteLine("Pizza is Baked.");
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }

        public void PrepareDough()
        {
            Pizza.Dough = "Pan";
        }

        public void SelectTopping(string topping)
        {
            Toppings.Add(topping);
        }
    }
}