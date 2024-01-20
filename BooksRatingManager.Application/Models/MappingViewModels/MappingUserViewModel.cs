using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Application.Models.MappingViewModels;

public static class MappingUserViewModel
{
    public static IEnumerable<UserViewModel> ToViewModel(this IEnumerable<User> users)
    {
        return users.Select(u => new UserViewModel(u.Name, u.Email));
    }

    public static UserDetailsViewModel ToViewModelWithId(this User user)
        => new(user.Name, user.Email, user.UserStatus.ToString());
}