using MediatR;

namespace BooksRatingManager.Application.Commands.UserCommands.InactiveUser;

public class InactiveUserCommand(int id) : IRequest<Unit>
{
    public int Id { get; set; } = id;
}