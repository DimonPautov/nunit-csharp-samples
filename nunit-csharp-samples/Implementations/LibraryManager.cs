/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        if (!_books.Contains(book))
        {
            _books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' already exists in the library.");
        }
        // TODO step 2.
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        if (_books.Contains(book))
        {
            _books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' not found in the library.");
        }
    }
}