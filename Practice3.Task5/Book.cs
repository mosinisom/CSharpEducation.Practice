using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
    internal class Book
    {
        public string Name { get; }
        public string Author { get; }
        public int Year { get; }

        public Book(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }

        public Book() : this("Название книги", "Автор книги", DateTime.Now.Year)
        {
        }

        public Book(string name) : this(name, "Автор книги", DateTime.Now.Year)
        {
        }

        public Book(string name, string author) : this(name, author, DateTime.Now.Year)
        {
        }
    }
}
