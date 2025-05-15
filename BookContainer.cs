using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class BookContainer
    {
        public delegate int BookComparer(Book book1, Book book2);
        public Book[] Books { get; set; }

   
        public BookContainer(Book[] books)
        {
            Books = books;
        }

 
        public void SortBooks(BookComparer comparer)
        {
            Array.Sort(Books, new Comparison<Book>((book1, book2) => comparer(book1, book2)));
        }

        public void DisplayBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
