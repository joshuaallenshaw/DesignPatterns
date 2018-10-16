using System;
using System.Collections.Generic;

namespace Builder.SimpleInterface
{
    /// <summary>
    /// A Concrete Builder Class
    /// </summary>
    internal class HawaiianPizzaBuilder : IPizzaBuilder
    {
        protected Pizza Pizza;
        protected List<string> Toppings = new List<string>();

        public HawaiianPizzaBuilder()
        {
            Pizza = new Pizza();
            SelectTopping("Mozzarella Cheese");
            SelectTopping("Pinapple");
            SelectTopping("Ham");
        }

        public void AddSauce()
        {
            Pizza.Sauce = "mild";
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
            Pizza.Dough = "Hand-Tossed";
        }

        public void SelectTopping(string topping)
        {
            Toppings.Add(topping);
        }
    }
}