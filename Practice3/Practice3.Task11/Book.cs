﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task11
{
    internal class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public string ToString(Book book)
        {
            return $"{book.Name} by {book.Author}";
        }
    }
}
