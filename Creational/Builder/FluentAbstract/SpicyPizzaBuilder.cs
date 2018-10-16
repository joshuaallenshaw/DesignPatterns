using System;

namespace Builder.FluentAbstract
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

        public override PizzaBuilder AddSauce()
        {
            Pizza.Sauce = "Hot";
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
            Pizza.Dough = "Pan";
            return this;
        }
    }
}