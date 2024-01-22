using BooksRatingManager.Application.Models.MappingViewModels;
using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Queries.ReviewsQueries.GetReviewsByBook;

public class GetReviewsByBookQueryHandler : IRequestHandler<GetReviewsByBookQuery, List<ReviewsViewModel>>
{
    private readonly IReviewRepository _reviewRepository;

    public GetReviewsByBookQueryHandler(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    public async Task<List<ReviewsViewModel>> Handle(GetReviewsByBookQuery request, CancellationToken cancellationToken)
    {
        var reviews = await _reviewRepository.GetReviewsByBookAsync(request.Id);

        return reviews
            .ToViewModel()
            .ToList();
    }
}