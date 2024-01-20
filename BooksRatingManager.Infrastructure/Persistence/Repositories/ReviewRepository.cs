using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooksRatingManager.Infrastructure.Persistence.Repositories;

public class ReviewRepository : IReviewRepository
{
    private readonly BooksRatingManagerDbContext _dbContext;

    public ReviewRepository(BooksRatingManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Review>> GetReviewsByBookAsync(int id)
    {
        return await _dbContext.Reviews.Where(r => r.IdBook == id)
            .Include(r => r.Book)
            .Include(r => r.User)
            .ToListAsync();
    }

    public async Task CreateReviewAsync(Review review)
    {
        await _dbContext.Reviews.AddAsync(review);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}