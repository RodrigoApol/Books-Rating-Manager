using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Core.Repositories;

public interface IReviewRepository
{
    Task<List<Review>> GetReviewsByBookAsync(int id);
    Task CreateReviewAsync(Review review);
    Task SaveChangesAsync();
}