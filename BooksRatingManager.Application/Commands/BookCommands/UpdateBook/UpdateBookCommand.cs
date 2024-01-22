using System.Text.Json.Serialization;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.UpdateBook;

public class UpdateBookCommand(int id) : IRequest<Unit>
{
    public int Id { get; set; } = id;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int PublicationYear { get; set; }
}