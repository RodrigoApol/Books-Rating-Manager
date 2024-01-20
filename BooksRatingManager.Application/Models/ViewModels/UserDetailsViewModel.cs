using BooksRatingManager.Core.Entities;
using MediatR;

namespace BooksRatingManager.Application.Models.ViewModels;

public class UserDetailsViewModel : IRequest
{
    public UserDetailsViewModel(string name, string email, string userStatus)
    {
        Name = name;
        Email = email;
        UserStatus = userStatus;
        Reviews = new List<ReviewsViewModel>();
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string UserStatus { get; set; }
    public List<ReviewsViewModel> Reviews { get; set; }
}