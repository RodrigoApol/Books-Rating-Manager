using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.ReviewsCommands.CreateReview;

public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand, int>
{
    private readonly IReviewRepository _reviewRepository;
    private readonly IBookRepository _bookRepository;

    public CreateReviewCommandHandler(IReviewRepository reviewRepository, IBookRepository bookRepository)
    {
        _reviewRepository = reviewRepository;
        _bookRepository = bookRepository;
    }
    
    public async Task<int> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        var review = new Review(request.Rating, request.Description, request.IdUser, request.IdBook);

        await _reviewRepository.CreateReviewAsync(review);
        await _bookRepository.UpdateAverage(request.IdBook);
        await _reviewRepository.SaveChangesAsync();

        return review.Id;
    }
}