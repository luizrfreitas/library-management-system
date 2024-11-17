using LibraryManegementSystem.Features.Books;

namespace LibraryManegementSystem.Features.Library
{
    public static class Options
    {
        public static void AddBookOption() {
            Console.WriteLine("Adding a new book...");

            Console.WriteLine("Enter title: ");
            string? title = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            string? author = Console.ReadLine();
            Console.WriteLine("Enter ISBN: ");
            string? isbn = Console.ReadLine();

            if (title == null) {
                throw new ArgumentException("title");
            }

            if (author == null) {
                throw new ArgumentException("author");
            }

            if (isbn == null) {
                throw new ArgumentException("isbn");
            }

            AbstractBook book = new Book(title, author, isbn);

            LibraryActions.AddBookAction(book);
        }

        public static void ListBookOption() {
            throw new NotImplementedException();
        }

        public static void SearchForBookOption() {
            throw new NotImplementedException();
        }

        public static void BorrowABookOption () {
            throw new NotImplementedException();
        }

        public static void ReturnABookOption () {
            throw new NotImplementedException();
        }

        public static void ExitLibrary() {
            throw new NotImplementedException();
        }
    }
}