using System;

namespace Builder
{
    /// <summary>
    /// A Concrete Builder Class
    /// </summary>
    internal class HawaiianPizzaBuilder : PizzaBuilder
    {
        public HawaiianPizzaBuilder()
        {
            SelectTopping("Mozzarella Cheese");
            SelectTopping("Pinapple");
            SelectTopping("Ham");
        }

        public override void AddSauce()
        {
            Pizza.Sauce = "mild";
        }

        public override void AddToppings()
        {
            Pizza.Toppings = Toppings;
        }

        public override void BakePizza()
        {
            Console.WriteLine("Pizza is Baked.");
        }

        public override void PrepareDough()
        {
            Pizza.Dough = "Hand-Tossed";
        }
    }
}