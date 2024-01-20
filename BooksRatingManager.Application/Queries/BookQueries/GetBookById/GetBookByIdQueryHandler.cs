using BooksRatingManager.Application.Models.MappingViewModels;
using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Queries.BookQueries.GetById;

public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDetailsViewModel>
{
    private readonly IBookRepository _bookRepository;

    public GetBookByIdQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public async Task<BookDetailsViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        var book = await _bookRepository.GetByIdAsync(request.Id);

        return book.ToViewModelWithId();
    }
}