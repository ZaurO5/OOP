class Program
{
    static void Main(string[] args)
    {
        LibraryBooks library = new LibraryBooks();
        library.AddBook(new Library.Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
        library.AddBook(new Library.Book("To Kill a Mockingbird", "Harper Lee", 1960));
        library.AddBook(new Library.Book("1984", "George Orwell", 1949));
        library.DisplayAllBooks();
    }
}
