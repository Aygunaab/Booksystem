using System;
using System.Collections.Generic;

namespace Booksystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            AppManager manager = new AppManager();
            manager.AddAuthor("Cingiz","Abdullayev");
            manager.AddAuthor("J.K", "Rowling");
            Author a1 = manager.GetAuthorById(1);
            manager.AddBook("Alcagin uslubu", 5, 300, a1);
            Author a2 = manager.GetAuthorById(2);
            manager.AddBook("Harry Potter", 15, 350, a2);
            foreach (var item in manager.GetBooks())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("End");


        }
    }
}
