namespace BooksRatingManager.Core.Entities.Base;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
}