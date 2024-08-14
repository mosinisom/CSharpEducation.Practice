namespace Practice3.Task4
{
    internal class Book
    {
        public string Name { get; }
        public string Author { get; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public Book() : this("Название книги", "Автор книги")
        {
        }
    }
}
