using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.DeleteBook;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, Unit>
{
    private readonly IBookRepository _bookRepository;

    public DeleteBookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        await _bookRepository.DeleteBookAsync(request.Id);
        await _bookRepository.SaveChangesAsync();
        
        return Unit.Value;
    }
}