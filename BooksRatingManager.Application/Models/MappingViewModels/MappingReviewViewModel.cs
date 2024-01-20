using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Application.Models.MappingViewModels;

public static class MappingReviewViewModel
{
    public static IEnumerable<ReviewsViewModel> ToViewModel(this IEnumerable<Review> reviews)
    {
        return reviews.Select(r => new ReviewsViewModel(r.Rating, r.Description));
    }
}