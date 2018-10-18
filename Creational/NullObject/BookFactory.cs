using System;

namespace NullObject
{
    public class BookFactory
    {
        public static string[] books = { "Book1", "Book2", "Book3" };

        /// <summary>
        /// The GetBook method returns the NullBook object, instead of a null.  This keeps the null check inside the method.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static AbstractBook GetBook(string title)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == title)
                {
                    return new Book(title);
                }
            }
            return new NullBook();
        }
    }
}