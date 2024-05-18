public class LibraryBooks 
{
    private List<Library.Book> books; 
    public LibraryBooks()
    {
        books = new List<Library.Book>();
    }
    public void AddBook(Library.Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }
    public void DisplayAllBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            book.DisplayDetails();
            Console.WriteLine();
        }
    }
}

