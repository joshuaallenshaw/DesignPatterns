using System.Collections.Generic;

namespace Builder.FluentAbstract
{
    /// <summary>
    /// Builder Class An interface can be used here as well, if looser coupling is desired.
    /// The Object returns are part of the fluent design.
    /// </summary>
    internal abstract class PizzaBuilder
    {
        protected Pizza Pizza;
        protected List<string> Toppings = new List<string>();

        public PizzaBuilder()
        {
            Pizza = new Pizza();
        }

        public abstract PizzaBuilder AddSauce();

        public abstract PizzaBuilder AddToppings();

        public abstract PizzaBuilder BakePizza();

        /// <summary>
        /// Returne the Built Object
        /// </summary>
        /// <returns></returns>
        public Pizza GetPizza()
        {
            return Pizza;
        }

        public abstract PizzaBuilder PrepareDough();

        /// <summary>
        /// The idea behind a builder design is to simplify paramater intake into steps
        /// </summary>
        /// <param name="topping"></param>
        public void SelectTopping(string topping)
        {
            Toppings.Add(topping);
        }
    }
}