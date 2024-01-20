namespace BooksRatingManager.Application.Models.ViewModels;

public class UserViewModel(string name, string email)
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
}