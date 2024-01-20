using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.BookCommands.CreateBook;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
{
    private readonly IBookRepository _bookRepository;

    public CreateBookCommandHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var book = new Book(
            request.Title,
            request.Description,
            request.ISBN,
            request.Author,
            request.Publisher,
            request.Genre,
            request.YearPublication,
            request.Pages);

        await _bookRepository.CreateBookAsync(book); //
        await _bookRepository.SaveChangesAsync();

        return book.Id;
    }
}