using System.Text.Json.Serialization;
using BooksRatingManager.Core.Entities.Base;

namespace BooksRatingManager.Core.Entities;

public class Review : BaseEntity
{
    protected Review()
    {
        
    }
    
    public Review(int rating, string description, int idUser, int idBook)
    {
        Rating = rating;
        Description = description;
        IdUser = idUser;
        IdBook = idBook;
        CreatedAt = DateTime.Now;
    }
    public int Rating { get; private set; }
    public string Description { get; private set; }
    [JsonIgnore]
    public User User { get; private set; }
    public int IdUser { get; private set; }
    [JsonIgnore]
    public Book Book { get; private set; }
    public int IdBook { get; private set; }

    public bool ReviewIsValid()
    {
        return Rating >= 1 && Rating <= 5;
    }
}