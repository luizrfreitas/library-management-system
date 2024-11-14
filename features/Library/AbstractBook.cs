namespace LibraryManegementSystem.Features.Library
{
    public abstract class AbstractBook
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string ISBN { get; set; } = "";
        public bool IsBorrowed { get; set; } = false;

        public void PrintBookData()
        {
            Console.WriteLine($"Title: {Title} - Author: {Author} - ISBN: {ISBN}");
        }
    }
}