using BooksRatingManager.Application.Models.ViewModels;
using MediatR;

namespace BooksRatingManager.Application.Queries.ReviewsQueries.GetReviewsByBook;

public class GetReviewsByBookQuery(int id) : IRequest<List<ReviewsViewModel>>
{
    public int Id { get; set; } = id;
}