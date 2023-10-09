namespace Lektion19Dist.Classes;

public class Book
{
    public int Id { get; init; }
    public string Title { get; init; }

    public Book(int id, string title) => (Id, Title) = (id, title);
}
