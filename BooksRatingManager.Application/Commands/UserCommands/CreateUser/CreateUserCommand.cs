using BooksRatingManager.Core.Entities;
using MediatR;

namespace BooksRatingManager.Application.Commands.UserCommands.CreateUser;

public class CreateUserCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}