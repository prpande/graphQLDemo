/// <summary>
/// Provides GraphQL mutation resolvers for modifying data in the library.
/// </summary>
public class Mutation
{
    /// <summary>
    /// Adds a new book to the library with the specified details.
    /// </summary>
    /// <param name="title">The title of the book to add.</param>
    /// <param name="authorName">The name of the author who wrote the book.</param>
    /// <param name="description">An optional description of the book content.</param>
    /// <returns>The newly created book that was added to the library.</returns>
    public Book AddBook(string title, string authorName, string? description = null)
    {
        var newAuthor = new Author(Library.Books.Count + 1, authorName);
        var newBook = new Book(Library.Books.Count + 1, title, newAuthor, description);
        Library.Books.Add(newBook);
        return newBook;
    }
}
