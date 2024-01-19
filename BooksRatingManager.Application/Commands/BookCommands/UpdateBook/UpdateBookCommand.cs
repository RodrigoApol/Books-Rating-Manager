using System.Text.Json.Serialization;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.UpdateBook;

public class UpdateBookCommand(int id) : IRequest<Unit>
{
    [JsonIgnore]
    public int Id { get; set; } = id;
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
}