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
    }
    public int Note { get; private set; }
    public string Description { get; private set; }
    public int IdUser { get; private set; }
    public int IdBook { get; private set; }
}