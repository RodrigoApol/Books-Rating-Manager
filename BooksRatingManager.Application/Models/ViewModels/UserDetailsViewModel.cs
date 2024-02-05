using BooksRatingManager.Core.Entities;
using MediatR;

namespace BooksRatingManager.Application.Models.ViewModels;

public class UserDetailsViewModel
{
    public UserDetailsViewModel(string name, string email, string userStatus, List<ReviewsViewModel> reviews)
    {
        Name = name;
        Email = email;
        UserStatus = userStatus;
        Reviews = reviews;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    public string UserStatus { get; set; }
    public List<ReviewsViewModel> Reviews { get; set; }
}