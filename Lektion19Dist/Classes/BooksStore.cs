namespace Lektion19Dist.Classes;

public class BooksStore
{
    List<Book> books = new()
    {
        new Book(1, "Title 1"),
        new Book(2, "Title 2")
    };

    public List<Book> GetBooks()
    {
        return books;
    }

    public IEnumerable<Book> GetEBooks()
    {
        return books;
    }
}
