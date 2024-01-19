using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Application.Models.ViewModels;

public class BookDetailsViewModel
{
    public BookDetailsViewModel(string title, string description, string isbn, string author, string publisher, string genre, int publicationYear, int pages, decimal average, byte[] cover)
    {
        Title = title;
        Description = description;
        ISBN = isbn;
        Author = author;
        Publisher = publisher;
        Genre = genre;
        PublicationYear = publicationYear;
        Pages = pages;
        Average = average;
        Cover = cover;

        Reviews = new List<Review>();
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public string ISBN { get; set; }
    public string Author { get;  set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public int PublicationYear { get; set; }
    public int Pages { get; set; }
    public decimal Average { get; set; }
    public byte[] Cover { get; set; }
    public List<Review> Reviews { get; set; }
}