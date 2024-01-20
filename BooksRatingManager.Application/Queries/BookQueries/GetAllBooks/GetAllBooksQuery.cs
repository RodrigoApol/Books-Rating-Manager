using BooksRatingManager.Application.Models.ViewModels;
using MediatR;

namespace BooksRatingManager.Application.Queries.BookQueries.GetAllBooks;

public class GetAllBooksQuery : IRequest<List<BookViewModel>>
{
    
}