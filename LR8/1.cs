using System;
using System.Collections.Generic;
using System.Linq;

namespace LR8
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public void Print()
        {
            Console.WriteLine($"'{Title}' — {Author}");
        }
    }
    public class Library
    {
        private string name;
        private List<Book> books;
        public Library()
        {
            name = "Безымянная библиотека";
            books = new List<Book>();
        }
        public Library(string name)
        {
            this.name = name;
            books = new List<Book>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void AddBook(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Ошибка: нельзя добавить пустую книгу.");
                return;
            }

            books.Add(book);
            Console.WriteLine($"Книга '{book.Title}' добавлена в библиотеку.");
        }
        public bool RemoveBook(string title, string author)
        {
            Book bookToRemove = books.FirstOrDefault(b =>
                b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) &&
                b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Книга '{title}' автора {author} удалена.");
                return true;
            }
            else
            {
                Console.WriteLine($"Книга '{title}' автора {author} не найдена.");
                return false;
            }
        }
        public List<Book> FindBooksByAuthor(string author)
        {
            var foundBooks = books.Where(b =>
                b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundBooks.Count == 0)
            {
                Console.WriteLine($"Книги автора '{author}' не найдены.");
            }
            else
            {
                Console.WriteLine($"Найдено книг'{author}': {foundBooks.Count}");
                foreach (var book in foundBooks)
                {
                    book.Print();
                }
            }
            return foundBooks;
        }
        public void PrintAllBooks()
        {
            Console.WriteLine($"\nКниги в библиотеке \"{name}\":");
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотека пуста —");
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    books[i].Print();
                }
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Городская библиотека им. Пушкина");
            Console.WriteLine($"=== {library.Name} ===\n");
            Book book1 = new Book("ПДД", "синегуб");
            Book book2 = new Book("C#", "Фимонович");
            Book book3 = new Book("Java", "Таль");
            Book book4 = new Book("JS", "Латышев");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.PrintAllBooks();
            Console.WriteLine("Поиск книг синегуба:");
            library.FindBooksByAuthor("синегуб");
            Console.WriteLine("\nУдаляем книги 'ПДД'");
            library.RemoveBook("ПДД", "синегуб");
            library.PrintAllBooks();
            library.FindBooksByAuthor("синегуб");
            Console.ReadKey();
        }
    }
}
