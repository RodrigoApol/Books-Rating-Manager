namespace BooksRatingManager.Application.Models.ViewModels;

public class BookViewModel
{
    public BookViewModel(string title, string description, string isbn, string author, int publicationYear, string genre)
    {
        Title = title;
        Description = description;
        ISBN = isbn;
        Author = author;
        PublicationYear = publicationYear;
        Genre = genre;
    }

    public string Title { get; set; }
    public string  Description { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public string Genre { get; set; }
}