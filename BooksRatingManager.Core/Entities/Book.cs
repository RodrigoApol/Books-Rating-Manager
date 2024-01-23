using BooksRatingManager.Core.Entities.Base;
using BooksRatingManager.Core.Enums;

namespace BooksRatingManager.Core.Entities;

public class Book : BaseEntity
{
    protected Book()
    {
    }

    public Book(
        string title,
        string description,
        string isbn,
        string author,
        string publisher,
        EBookGenre genre,
        int publicationYear,
        int pages)
    {
        Title = title;
        Description = description;
        ISBN = isbn;
        Author = author;
        Publisher = publisher;
        Genre = genre;
        PublicationYear = publicationYear;
        Pages = pages;
        Average = 0;
        Reviews = new List<Review>();
        CreatedAt = DateTime.Now;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public string ISBN { get; private set; }
    public string Author { get; private set; }
    public string Publisher { get; private set; }
    public EBookGenre Genre { get; private set; }
    public int PublicationYear { get; private set; }
    public int Pages { get; private set; }
    public decimal Average { get; private set; }
    public byte[]? Cover { get;  set; }
    public List<Review> Reviews { get; private set; }

    public void UpdateBook(
        string title,
        string description,
        string author,
        int publicationYear)
    {
        Title = title;
        Description = description;
        Author = author;
        PublicationYear = publicationYear;
    }

    public void UploadCover(byte[] cover)
    {
        Cover = cover;
    }

    public void UpdateAverage()
    {
        decimal sum = 0;

        if (Reviews.Count > 0)
        {
            foreach (var review in Reviews)
            {
                sum += review.Rating;
            }
            
            Average = sum / Reviews.Count;
        }
        else
        {
            Average = 0;
        }
    }
}