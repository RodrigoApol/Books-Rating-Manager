using BooksRatingManager.Core.Enums;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.CreateBook;

public class CreateBookCommand : IRequest<int>
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public EBookGenre Genre { get; set; }
    public int YearPublication { get; set; }
    public int Pages { get; set; }
}