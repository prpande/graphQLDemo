/// <summary>
/// A static library class that serves as a runtime cache for storing book data.
/// This class provides centralized access to the book collection for both queries and mutations.
/// </summary>
public static class Library
{
    /// <summary>
    /// Gets the collection of books in the library.
    /// This serves as the primary data store for the application and is initialized with sample data.
    /// </summary>
    public static List<Book> Books { get; } =
        new()
        {
            new Book(
                1,
                "Clean Code",
                new Author(1, "Robert C. Martin"),
                "A comprehensive guide to writing clean, readable code"
            ),
            new Book(
                2,
                "The Pragmatic Programmer",
                new Author(2, "Andrew Hunt"),
                "Your journey to mastery"
            ),
        };
}
