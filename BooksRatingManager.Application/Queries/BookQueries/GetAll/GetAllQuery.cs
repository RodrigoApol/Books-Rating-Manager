using BooksRatingManager.Application.Models.ViewModels;
using MediatR;

namespace BooksRatingManager.Application.Queries.BookQueries.GetAll;

public class GetAllQuery : IRequest<List<BookViewModel>>
{
    
}