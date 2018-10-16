using System;

namespace Builder
{
    /// <summary>
    /// A Concrete Builder Class
    /// </summary>
    internal class SpicyPizzaBuilder : PizzaBuilder
    {
        public SpicyPizzaBuilder()
        {
            SelectTopping("Mozzarella Cheese");
            SelectTopping("Pepperoni");
            SelectTopping("Salami");
        }

        public override void AddSauce()
        {
            Pizza.Sauce = "Hot";
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
            Pizza.Dough = "Pan";
        }
    }
}