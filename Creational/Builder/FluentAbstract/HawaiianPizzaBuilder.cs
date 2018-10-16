using System;

namespace Builder.FluentAbstract
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

        public override PizzaBuilder AddSauce()
        {
            Pizza.Sauce = "mild";
            return this;
        }

        public override PizzaBuilder AddToppings()
        {
            Pizza.Toppings = Toppings;
            return this;
        }

        public override PizzaBuilder BakePizza()
        {
            Console.WriteLine("Pizza is Baked.");
            return this;
        }

        public override PizzaBuilder PrepareDough()
        {
            Pizza.Dough = "Hand-Tossed";
            return this;
        }
    }
}