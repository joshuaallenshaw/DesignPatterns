using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// Builder Class An interface can be used here as well, if looser coupling is desired.
    /// </summary>
    internal abstract class PizzaBuilder
    {
        protected Pizza Pizza;
        protected List<string> Toppings = new List<string>();

        public PizzaBuilder()
        {
            Pizza = new Pizza();
        }

        public abstract void AddSauce();

        public abstract void AddToppings();

        public abstract void BakePizza();

        /// <summary>
        /// Returne the Built Object
        /// </summary>
        /// <returns></returns>
        public Pizza GetPizza()
        {
            return Pizza;
        }

        public abstract void PrepareDough();

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