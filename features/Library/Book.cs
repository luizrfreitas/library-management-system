namespace LibraryManegementSystem.Features.Library
{
    public class Book : AbstractBook
    {
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
}