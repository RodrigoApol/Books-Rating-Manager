using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Core.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User> GetDetailsAsync(int id);
    Task CreateUserAsync(User user);
    Task UpdateUserAsync(int id, User user);
    Task DeleteUserAsync(int id);
    Task SaveChangesAsync();
}