using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class UniqueAuthors
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public UniqueAuthors(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Releasedate { get; set; }
        public double ISBN { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releasedate, double isbn, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Releasedate = releasedate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }  
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var title = input[0];
                var author = input[1];
                var publisher = input[2];
                DateTime releasedate = DateTime.ParseExact(input[3], "dd.MM.yyyy",CultureInfo.InvariantCulture);
                double ISBN = double.Parse(input[4]);
                double price = double.Parse(input[5]);

                Book book = new Book(title, author, publisher, releasedate, ISBN, price);

                books.Add(book);
            }

            Library library = new Library("biblioteka1", books);

            var ordered = library.Books.GroupBy(x => x.Author)
                .Select(g => new
                {
                    Author = g.Key,
                    Prices = g.Sum(s => s.Price)
                })
                .OrderByDescending(x=>x.Prices)
                .ThenBy(x=>x.Author)
                .ToList();


            foreach (var book in ordered)
             
            {
                Console.WriteLine("{0} -> {1:f2}", book.Author, book.Prices);
            } 
        }
    }
}