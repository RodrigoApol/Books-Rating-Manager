using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Infrastructure.Persistence;

public class BooksRatingManagerDbContext
{
    public BooksRatingManagerDbContext()
    {
        Books = new List<Book>();
        Reviews = new List<Review>();
        Users = new List<User>();
    }
    
    public List<Book> Books { get;  set; }
    public List<Review> Reviews { get; set; }
    public List<User> Users { get; set; }
        
}