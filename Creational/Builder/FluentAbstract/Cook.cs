namespace Builder.FluentAbstract

{
    /// <summary>
    /// The Director Class
    /// </summary>
    internal class Cook
    {
        private PizzaBuilder pizzaBuilder;

        /// <summary>
        /// The fluent design for the builder allow for us to chain it all together
        /// </summary>
        public Cook ConstructPizza()
        {
            pizzaBuilder.PrepareDough()
            .AddSauce()
            .AddToppings()
            .BakePizza();
            return this;
        }

        /// <summary>
        /// A fluent set builder method
        /// </summary>
        /// <param name="pb"></param>
        /// <returns></returns>
        public Cook SetPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
            return this;
        }
    }
}