/// <summary>
/// Represents a book in the library with its basic information and author details.
/// </summary>
/// <param name="Id">The unique identifier for the book.</param>
/// <param name="Title">The title of the book.</param>
/// <param name="Author">The author who wrote the book.</param>
/// <param name="Description">An optional description of the book content.</param>
public record Book(int Id, string Title, Author Author, string? Description = null);
