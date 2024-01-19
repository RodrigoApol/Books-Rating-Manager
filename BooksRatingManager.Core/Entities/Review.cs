using System.Text.Json.Serialization;
using BooksRatingManager.Core.Entities.Base;

namespace BooksRatingManager.Core.Entities;

public class Review : BaseEntity
{
    protected Review()
    {
        
    }
    
    public Review(int note, string description, int idUser, int idBook)
    {
        Note = note;
        Description = description;
        IdUser = idUser;
        IdBook = idBook;
        CreatedAt = DateTime.Now;
    }
    public int Note { get; private set; }
    public string Description { get; private set; }
    [JsonIgnore]
    public User User { get; private set; }
    public int IdUser { get; private set; }
    [JsonIgnore]
    public Book Book { get; private set; }
    public int IdBook { get; private set; }
}