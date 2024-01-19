using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.UpdateBook;

public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, Unit>
{
    private readonly IBookRepository _bookRepository;

    public UpdateBookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        var book = await _bookRepository.GetByIdAsync(request.Id);

        book.UpdateBook(request.Title, request.Description, request.Author, request.PublicationYear);
        
        await _bookRepository.SaveChangesAsync();
        
        return Unit.Value;
    }
}