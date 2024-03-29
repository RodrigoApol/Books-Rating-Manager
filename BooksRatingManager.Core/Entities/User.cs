using BooksRatingManager.Core.Entities.Base;
using BooksRatingManager.Core.Enums;

namespace BooksRatingManager.Core.Entities;

public class User : BaseEntity
{
    protected User()
    {
        
    }
    
    public User(string name, string email)
    {
        Name = name;
        Email = email;
        
        UserStatus = EUserStatus.Active;
        Reviews = new List<Review>();
        CreatedAt = DateTime.Now.ToUniversalTime();
    }
    
    public string Name { get; private set; }
    public string Email { get; private set; }
    public EUserStatus UserStatus { get; private set; }
    public List<Review> Reviews { get; private set; }

    public void UpdateUser(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void InactiveUser()
    {
        UserStatus = EUserStatus.Inactive;
    }
}