namespace Builder.SimpleInterface
{
    /// <summary>
    /// The Director Class
    /// </summary>
    internal class Cook
    {
        private IPizzaBuilder pizzaBuilder;

        public void ConstructPizza()
        {
            pizzaBuilder.PrepareDough();
            pizzaBuilder.AddSauce();
            pizzaBuilder.AddToppings();
            pizzaBuilder.BakePizza();
        }

        public void SetPizzaBuilder(IPizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }
    }
}