using BooksRatingManager.Application.Models.ViewModels;
using MediatR;

namespace BooksRatingManager.Application.Queries.BookQueries.GetById;

public class GetBookByIdQuery(int id) : IRequest<BookDetailsViewModel>
{
    public int Id { get; set; } = id;
}