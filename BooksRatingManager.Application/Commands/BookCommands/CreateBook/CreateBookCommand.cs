using BooksRatingManager.Core.Enums;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.CreateBook;

public class CreateBookCommand : IRequest<int>
{
    public string Title { get;  set; }
    public string Description { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public EBookGenre Genre { get; set; }
    public int YearPublication { get; set; }
    public int Pages { get; set; }
}