using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// The Product Class
    /// </summary>
    public class Pizza
    {
        public string Dough { get; set; } = string.Empty;

        public string Sauce { get; set; } = string.Empty;

        public List<string> Toppings { get; set; } = new List<string>();
    }
}