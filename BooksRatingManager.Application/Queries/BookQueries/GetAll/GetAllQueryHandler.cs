using BooksRatingManager.Application.Models.MappingViewModels;
using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Queries.BookQueries.GetAll;

public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<BookViewModel>>
{
    private readonly IBookRepository _bookRepository;

    public GetAllQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<BookViewModel>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var books = await _bookRepository.GetAllAsync();

        return books
            .ToViewModel()
            .ToList();
    }
}