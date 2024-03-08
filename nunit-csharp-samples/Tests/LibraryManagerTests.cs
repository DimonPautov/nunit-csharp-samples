namespace nunit_csharp_samples.Tests
{
    [TestFixture]
    public class LibraryManagerTests
    {
        [Test]
        public void AddBook_BookNotInLibrary_ShouldAddBook()
        {
            LibraryManager manager = new LibraryManager();
            Book book = new Book { Title = "Sample Book", Author = "Sample Author", Articul = "123456" };

            manager.AddBook(book);

            Assert.Contains(book, manager.GetBooks());
        }

        [Test]
        public void AddBook_BookAlreadyInLibrary_ShouldNotAddBook()
        {
            LibraryManager manager = new LibraryManager();
            Book book = new Book { Title = "Sample Book", Author = "Sample Author", Articul = "123456" };

            manager.AddBook(book);
            manager.AddBook(book);

            Assert.AreEqual(1, manager.GetBooks().Count);
        }

        [Test]
        public void RemoveBook_BookInLibrary_ShouldRemoveBook()
        {
            LibraryManager manager = new LibraryManager();
            Book book = new Book { Title = "Sample Book", Author = "Sample Author", Articul = "123456" };
            manager.AddBook(book);

            manager.RemoveBook(book);

            Assert.IsEmpty(manager.GetBooks());
        }

        [Test]
        public void RemoveBook_BookNotInLibrary_ShouldNotRemoveBook()
        {
            LibraryManager manager = new LibraryManager();
            Book book = new Book { Title = "Sample Book", Author = "Sample Author", Articul = "123456" };

            manager.RemoveBook(book);

            Assert.IsEmpty(manager.GetBooks());
        }
    }
}