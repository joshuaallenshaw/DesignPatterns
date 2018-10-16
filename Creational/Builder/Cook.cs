namespace Builder
{
    /// <summary>
    /// The Director Class
    /// </summary>
    internal class Cook
    {
        private PizzaBuilder pizzaBuilder;

        public void ConstructPizza()
        {
            pizzaBuilder.PrepareDough();
            pizzaBuilder.AddSauce();
            pizzaBuilder.AddToppings();
            pizzaBuilder.BakePizza();
        }

        public void SetPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }
    }
}