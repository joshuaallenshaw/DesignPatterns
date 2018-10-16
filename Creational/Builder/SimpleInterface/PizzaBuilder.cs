using System.Collections.Generic;

namespace Builder.SimpleInterface
{
    /// <summary>
    /// Builder interface - An abstract class can be used here as well, if more structure is desired.
    /// </summary>
    internal interface IPizzaBuilder
    {
        void AddSauce();

        void AddToppings();

        void BakePizza();

        Pizza GetPizza();

        void PrepareDough();

        void SelectTopping(string topping);
    }
}