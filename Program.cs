using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книг: ");

            int bookCount = Convert.ToInt32(Console.ReadLine());


            Book[] books = new Book[bookCount];


            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"\nВведите данные для книги {i + 1}:");

                Console.Write("Введите название книги: ");
                string title = Console.ReadLine();

                Console.Write("Введите автора книги: ");
                string author = Console.ReadLine();

                Console.Write("Введите издательство книги: ");
                string publisher = Console.ReadLine();

                books[i] = new Book(title, author, publisher);
            }


            BookContainer container = new BookContainer(books);

            Console.WriteLine("\nВыберите критерий сортировки (1: Title, 2: Author, 3: Publisher): ");
            int choice = Convert.ToInt32(Console.ReadLine());


            BookComparer comparer = null;

            switch (choice)
            {
                case 1:
                    comparer = (book1, book2) => string.Compare(book1.Title, book2.Title);
                    break;
                case 2:
                    comparer = (book1, book2) => string.Compare(book1.Author, book2.Author);
                    break;
                case 3:
                    comparer = (book1, book2) => string.Compare(book1.Publisher, book2.Publisher);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Будет использоваться сортировка по названию.");
                    comparer = (book1, book2) => string.Compare(book1.Title, book2.Title);
                    break;
            }


            container.SortBooks(comparer);


            Console.WriteLine("\nОтсортированные книги:");
            container.DisplayBooks();
        }
    }
    
}
