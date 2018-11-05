/* Object Pool Pattern.
 * Keeps objects in a "pool" instead of destroying them.
 */

using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectPool
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var po01 = Pool.GetObject();
            po01.TempData = DateTime.Now.ToString("s");
            Console.WriteLine("First pool object created at {0}", po01.CreatedAt);
            Thread.Sleep(1000);

            var po02 = Pool.GetObject();
            po02.TempData = Guid.NewGuid().ToString("N");
            Console.WriteLine("Second pool object created at {0}", po02.CreatedAt);
            Thread.Sleep(1000);

            Pool.ReleaseObject(po01);
            var po03 = Pool.GetObject();
            po03.TempData = DateTime.Now.ToString("s");
            Console.WriteLine("Third pool object created at {0}", po03.CreatedAt);

            Console.WriteLine("Second pool object created at {0}", po02.CreatedAt);
            Pool.ReleaseObject(po02);

            Console.ReadLine();
        }
    }
}