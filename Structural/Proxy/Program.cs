/* GoF Proxy Pattern
 * Provide a surrogate or placeholder for another object to control access to it.
 */

using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("HiRes_10MB_Photo1");
            IImage image2 = new ProxyImage("HiRes_10MB_Photo2");

            image1.DisplayImage();
            image1.DisplayImage();
            image2.DisplayImage();
            image2.DisplayImage();

            Console.ReadKey();
        }
    }
}