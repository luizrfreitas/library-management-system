using System.Data;
using System.IO;

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
            string bookLine = $"{book.Title},{book.Author},{book.ISBN},{book.IsBorrowed}\n";
            File.AppendAllText(PathToBooks, bookLine);
        }
    }
}