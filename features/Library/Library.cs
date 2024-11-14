using System.Data;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace LibraryManegementSystem.Features.Library
{
    public static class LibraryHome
    {
        private static List<string> Menu { get; } = new List<string> {
            "Add a New Book",
            "List All Books",
            "Search for a Book",
            "Borrow a Book",
            "Return a Book",
            "Exit",
        };
        private static string PathToBooks { get; } = "./books/books.csv";

        public static void Home()
        {
            Console.WriteLine("Welcome to Library Management System.");
            Console.WriteLine("Menu: \n");

            PrintMenu();
            ReadOptionSelection();
        }

        private static void PrintMenu()
        {
            int index = 1;
            foreach (string option in Menu) {
                Console.WriteLine($"{index}: {option}");
                index++;
            }
        }

        private static void AddBook(AbstractBook book)
        {
            string[] bookLine = {book.Title, book.Author, book.ISBN};
            File.AppendAllLines(PathToBooks, bookLine);
        }

        public static void ListBooks()
        {
            using (TextFieldParser parser = new TextFieldParser(PathToBooks)) {
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

        private static void ReadOptionSelection()
        {
            Console.WriteLine("Choose an option from above: ");

            string? option = Console.ReadLine();

            if (option == null) {
                throw new ArgumentException("option");
            }

            // return option;
        }
    }
}