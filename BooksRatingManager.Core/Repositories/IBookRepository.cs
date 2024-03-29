using BooksRatingManager.Core.Entities;

namespace BooksRatingManager.Core.Repositories;

public interface IBookRepository
{
    Task<List<Book>> GetAllAsync();
    Task<Book> GetByIdAsync(int id);
    Task CreateBookAsync(Book book);
    Task UpdateAverage(int id);
    Task DeleteBookAsync(int id);
    Task SaveChangesAsync();
}