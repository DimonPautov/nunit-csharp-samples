namespace nunit_csharp_samples.Tests;

[TestFixture]
public class LibraryStatisticsAnalyzerTests
{
    [Test]
    public void GetBooksByAuthor_AuthorExists_ShouldReturnBooks()
    {
        LibraryManager manager = new LibraryManager();
        LibraryStatisticsAnalyzer analyzer = new LibraryStatisticsAnalyzer(manager);
        Book book1 = new Book { Title = "Book 1", Author = "Author 1", Articul = "111" };
        Book book2 = new Book { Title = "Book 2", Author = "Author 1", Articul = "222" };
        manager.AddBook(book1);
        manager.AddBook(book2);

        var result = analyzer.GetBooksByAuthor("Author 1");

        Assert.AreEqual(2, result.Count);
        Assert.Contains(book1, result);
        Assert.Contains(book2, result);
    }

    [Test]
    public void GetBookByTitle_TitleExists_ShouldReturnBook()
    {
        LibraryManager manager = new LibraryManager();
        LibraryStatisticsAnalyzer analyzer = new LibraryStatisticsAnalyzer(manager);
        Book book = new Book { Title = "Sample Book", Author = "Sample Author", Articul = "123456" };
        manager.AddBook(book);

        var result = analyzer.GetBookByTitle("Sample Book");

        Assert.IsNotNull(result);
        Assert.AreEqual(book, result);
    }

    [Test]
    public void GetBookByArticul_ArticulExists_ShouldReturnBook()
    {
        LibraryManager manager = new LibraryManager();
        LibraryStatisticsAnalyzer analyzer = new LibraryStatisticsAnalyzer(manager);
        Book book = new Book { Title = "Sample Book", Author = "Sample Author", Articul = "123456" };
        manager.AddBook(book);

        var result = analyzer.GetBookByArticul("123456");

        Assert.IsNotNull(result);
        Assert.AreEqual(book, result);
    }
}