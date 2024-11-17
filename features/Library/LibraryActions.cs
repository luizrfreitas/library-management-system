using LibraryManegementSystem.Features.Books;
using Microsoft.VisualBasic.FileIO;

namespace LibraryManegementSystem.Features.Library
{
    public static class LibraryActions
    {
        public static void AddBookAction(AbstractBook book)
        {
            string[] bookLine = {book.Title, book.Author, book.ISBN};
            File.AppendAllLines(LibraryHome.PathToBooks, bookLine);

            Console.WriteLine("Book created with success!");
        }

        public static void ListBookAction()
        {
            using (TextFieldParser parser = new TextFieldParser(LibraryHome.PathToBooks)) {
                parser.HasFieldsEnclosedInQuotes = true;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    AbstractBook book = new Book(fields[0], fields[1], fields[2]);

                    book.PrintBookData();
                }
            }
        }
    }
}