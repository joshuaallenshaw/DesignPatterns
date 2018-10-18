using System;

namespace NullObject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            AbstractBook c1 = BookFactory.GetBook("Book1");
            AbstractBook c2 = BookFactory.GetBook("Book5");
            AbstractBook c3 = BookFactory.GetBook("Book2");
            AbstractBook c4 = BookFactory.GetBook("Book3");
            AbstractBook c5 = BookFactory.GetBook("Book9");

            /* Without a null object, you would need a null check in here, before you trieds using one of those books.
             * if(c2 != null){ c2.GetTitle(); }
             */

            Console.WriteLine(c1.GetTitle());
            Console.WriteLine(c2.GetTitle());
            Console.WriteLine(c3.GetTitle());
            Console.WriteLine(c4.GetTitle());
            Console.WriteLine(c5.GetTitle());

            Console.ReadLine();
        }
    }
}