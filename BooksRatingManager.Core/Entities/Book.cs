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
        int yearPublication, 
        int pages, 
        decimal average, 
        byte cover)
    {
        Title = title;
        Description = description;
        ISBN = isbn;
        Author = author;
        Publisher = publisher;
        Genre = genre;
        YearPublication = yearPublication;
        Pages = pages;
        Average = average;
        Cover = cover;
        Reviews = new List<Review>();
    }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string ISBN { get; private set; }
    public string Author { get; private set; }
    public string Publisher { get; private set; }
    public EBookGenre Genre { get; private set; }
    public int YearPublication { get; private set; }
    public int Pages { get; private set; }
    public decimal Average { get; private set; }
    public byte Cover { get; private set; }
    public List<Review> Reviews { get; private set; }
}