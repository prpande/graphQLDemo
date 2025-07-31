/// <summary>
/// Provides GraphQL query resolvers for retrieving data from the library.
/// </summary>
public class Query
{
    /// <summary>
    /// Returns a greeting message.
    /// This is a simple query to demonstrate the GraphQL setup.
    /// </summary> <summary>
    public string Hello()
    {
        return "Hello world";
    }

    /// <summary>
    /// Gets all books from the library.
    /// </summary>
    /// <returns>A collection of all books in the library.</returns>
    public IEnumerable<Book> GetBooks() => Library.Books;

    /// <summary>
    /// Gets a specific book by its ID.
    /// </summary>
    /// <param name="id">The unique identifier of the book to retrieve.</param>
    /// <returns>The book with the specified ID, or null if not found.</returns>
    public Book? GetBook(int id) => Library.Books.FirstOrDefault(book => book.Id == id);

    /// <summary>
    /// Gets all unique authors from the books in the library.
    /// </summary>
    /// <returns>A collection of distinct authors who have written books in the library.</returns>
    public IEnumerable<Author> GetAuthors() => Library.Books.Select(book => book.Author).Distinct();
}
