using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// The Flyweight Factory Class
    /// </summary>
    public class CoffeeFlavorFactory
    {
        private readonly IDictionary<string, CoffeeFlavor> flavors = new Dictionary<string, CoffeeFlavor>();

        public int TotalFlaversMade
        {
            get
            {
                return flavors.Count;
            }
        }

        public CoffeeFlavor GetCoffeeFlavor(string flavorName)
        {
            if (!flavors.TryGetValue(flavorName, out CoffeeFlavor flavor))
            {
                flavor = new CoffeeFlavor(flavorName);
                flavors.Add(flavorName, flavor);
            }

            return flavor;
        }
    }
}