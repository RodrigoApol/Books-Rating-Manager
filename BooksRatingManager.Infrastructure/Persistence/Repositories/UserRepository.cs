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
        var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);

        return user ?? throw new Exception();
    }

    public async Task CreateUserAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
    }
    

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}