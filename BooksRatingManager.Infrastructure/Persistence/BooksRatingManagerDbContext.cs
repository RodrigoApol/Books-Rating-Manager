using System.Reflection;
using BooksRatingManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksRatingManager.Infrastructure.Persistence;

public class BooksRatingManagerDbContext : DbContext
{
    public BooksRatingManagerDbContext(DbContextOptions<BooksRatingManagerDbContext> options) : base(options)
    {
    }
    
    public DbSet<Book> Books { get;  set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}