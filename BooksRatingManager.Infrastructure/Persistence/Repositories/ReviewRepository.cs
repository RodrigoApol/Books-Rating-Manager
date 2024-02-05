using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Enums;
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
        var book = await _dbContext.Books.SingleOrDefaultAsync(b => b.Id == review.IdBook)
                   ?? throw new ArgumentException("Book not Exists");

        var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == review.IdUser)
                   ?? throw new ArgumentException("User not Exists");

        if (user.UserStatus == EUserStatus.Inactive)
        {
            throw new ArgumentException("User status is not valid");
        }

        if (review.ReviewIsValid() == false)
        {
            throw new ArgumentException("Rating is not valid");
        }

        await _dbContext.Reviews.AddAsync(review);
        await _dbContext.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}