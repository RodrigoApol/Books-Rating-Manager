using BooksRatingManager.Application.Models.ViewModels;
using MediatR;

namespace BooksRatingManager.Application.Queries.UserQueries.GetUserById;

public class GetUserByIdQuery(int id) : IRequest<UserDetailsViewModel>
{
    public int Id { get; set; } = id;
}