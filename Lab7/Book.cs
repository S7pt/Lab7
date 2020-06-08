using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab7
{
    public class Book : IComparable
    {
        public int price;
        public int pagesCount;
        public string author;
        public string genre;
        public int yearOfProduction;

        public Book(int price, int pagesCount, string author, string genre, int yearOfProduction)
        {
            this.price = price;
            this.pagesCount = pagesCount;
            this.author = author;
            this.genre = genre;
            this.yearOfProduction = yearOfProduction;
        }

        public int CompareTo(object other)
        {
            Book book = (Book) other;
            return price - book.price;
        }

        

        public override string ToString()
        {
            return "|" + price + "|" + pagesCount + "|" + author + "|" + genre + "|" + yearOfProduction + "|";
        }

        public class Books : IEnumerable
        {
           public Book[] bookArray;
           private int count = 0;

            public Books(int count)
            {
                bookArray = new Book[count];
            }

            public IEnumerator GetEnumerator()
            {
                return bookArray.GetEnumerator();
            }

            public void Add(Book item)
            {
                if (count == bookArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                bookArray[count] = item;
                count++;
            }
            public class CompareClass:IComparer<Book>
            {
                public int Compare(Book x, Book y)
                {
                    int comparer = x.price - y.price;
                    if (comparer != 0)
                    {
                        return comparer;
                    }

                    comparer = x.pagesCount - y.pagesCount;
                    return comparer;
                }
            }

            public void SortByPriceAndPagesCount()
            {
                List<Book> bookList=new List<Book>();
                foreach (Book bookUnit in bookArray)
                {
                    bookList.Add(bookUnit);
                }
                CompareClass compareClass=new CompareClass();
                bookList.Sort(compareClass);
                int i = 0;
                foreach (Book bookUnit in bookList)
                {
                    bookArray[i] = bookUnit;
                    i++;
                }
            }
        }
    }
}