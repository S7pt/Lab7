using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the number of elements in list: ");
            int counter = int.Parse(Console.ReadLine());
            Book.Books bookArray = new Book.Books(counter);
            for (int i = 0; i < bookArray.bookArray.Length; i++)
            {
                Console.Write(i+1+" Book price:");
                int priceCounter = int.Parse(Console.ReadLine());
                Console.Write(i+1+" Book pages:");
                int pagesCounter = int.Parse(Console.ReadLine());
                Console.Write(i + 1 + " Book author:");
                string author = Console.ReadLine();
                Console.Write(i + 1 + " Book genre:");
                string genre = Console.ReadLine();
                Console.Write(i + 1 + " Book year of creating:");
                int year = int.Parse(Console.ReadLine());
                bookArray.Add(new Book(priceCounter,pagesCounter,author,genre,year));
            }
            Console.WriteLine("Before sorting:");
            Console.WriteLine();
            Console.WriteLine();
            foreach (Book bookUnit in bookArray)
            {
                Console.WriteLine(bookUnit);
            }

            bookArray.SortByPriceAndPagesCount();
            Console.WriteLine("After sorting:");
            Console.WriteLine();
            Console.WriteLine();
            foreach (Book bookUnit in bookArray)
            {
                Console.WriteLine(bookUnit);
            }
        }
    }
}