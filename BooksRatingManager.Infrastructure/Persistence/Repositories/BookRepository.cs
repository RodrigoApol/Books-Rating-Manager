using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BooksRatingManager.Infrastructure.Persistence.Repositories;

public class BookRepository : IBookRepository
{
    private readonly BooksRatingManagerDbContext _dbContext;

    public BookRepository(BooksRatingManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Book>> GetAllAsync()
    {
        return await _dbContext.Books.ToListAsync();
    }

    public async Task<Book> GetByIdAsync(int id)
    {
        var book = await _dbContext.Books
            .Include(b => b.Reviews)
            .SingleOrDefaultAsync(b => b.Id == id);

        return book ?? throw new Exception();
    }

    public async Task CreateBookAsync(Book book)
    {
        await _dbContext.Books.AddAsync(book);
    }

    public async Task UpdateAverage(int id)
    {
        var book = await _dbContext.Books
            .Include(b => b.Reviews)
            .SingleOrDefaultAsync(b => b.Id == id);

        if (book is null)
        {
            throw new ArgumentException("Book not exists");
        }

        book.UpdateAverage();
    }

    public async Task DeleteBookAsync(int id)
    {
        var book = await _dbContext.Books.SingleOrDefaultAsync(b => b.Id == id);

        if (book is null)
        {
            throw new Exception();
        }

        _dbContext.Books.Remove(book);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}