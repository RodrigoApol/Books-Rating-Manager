using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooksRatingManager.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly BooksRatingManagerDbContext _dbContext;

    public UserRepository(BooksRatingManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<User> GetDetailsAsync(int id)
    {
        var user = await _dbContext.Users.
            Include(u => u.Reviews)
            .SingleOrDefaultAsync(u => u.Id == id);

        return user ?? throw new ArgumentException("User not found");
    }

    public async Task CreateUserAsync(User user)
    {
        var alreadyRegisteredUser = _dbContext.Users.SingleOrDefault(u => u.Email == user.Email);

        if (alreadyRegisteredUser is not null)
        {
            throw new ArgumentException("already registered user");
        }

        await _dbContext.Users.AddAsync(user);
    }
    
    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}