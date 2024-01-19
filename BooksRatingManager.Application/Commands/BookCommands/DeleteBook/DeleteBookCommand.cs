using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.DeleteBook;

public class DeleteBookCommand(int id) : IRequest<Unit>
{
    public int Id { get; set; } = id;
}