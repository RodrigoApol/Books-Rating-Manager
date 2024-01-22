using System.Text.Json.Serialization;
using MediatR;

namespace BooksRatingManager.Application.Commands.UserCommands.UpdateUser;

public class UpdateUserCommand(int id, string name, string email) : IRequest<Unit>
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
}