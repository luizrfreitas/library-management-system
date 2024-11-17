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
        public static string PathToBooks { get; } = "./books/books.csv";

        public static void Home()
        {
            Console.WriteLine("Menu: \n");

            PrintMenu();
            int option = ReadOptionSelection();

            switch (option)
            {
                case 1:
                    Options.AddBookOption();
                    break;
                case 2:
                    Options.ListBookOption();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        private static void PrintMenu()
        {
            int index = 1;
            foreach (string option in Menu) {
                Console.WriteLine($"{index}: {option}");
                index++;
            }
        }

        private static int ReadOptionSelection()
        {
            Console.WriteLine("Choose an option from above: ");

            string? option = Console.ReadLine();

            if (option == null) {
                throw new ArgumentException("option");
            }

            return int.Parse(option);
        }
    }
}