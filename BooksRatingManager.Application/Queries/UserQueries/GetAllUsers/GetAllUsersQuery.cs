using BooksRatingManager.Application.Models.ViewModels;
using MediatR;

namespace BooksRatingManager.Application.Queries.UserQueries.GetAll;

public class GetAllUsersQuery : IRequest<List<UserViewModel>>
{
    
}