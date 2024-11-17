namespace LibraryManegementSystem.Features.CsvHandler
{
    public interface ICsvHandler
    {
        public void AddLine(string[] line);
        public string[] FindLine(string needle, string path, int column);
    }
}