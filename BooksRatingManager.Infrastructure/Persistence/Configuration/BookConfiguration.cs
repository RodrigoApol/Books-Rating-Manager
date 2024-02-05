using BooksRatingManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksRatingManager.Infrastructure.Persistence.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.Id);

        builder
            .HasMany(b => b.Reviews)
            .WithOne(r => r.Book)
            .HasForeignKey(r => r.IdBook)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(b => b.Title)
            .HasMaxLength(50)
            .HasColumnType("varchar(50)");
        
        builder
            .Property(b => b.Description)
            .HasMaxLength(100)
            .HasColumnType("varchar(100)");
        
        builder
            .Property(b => b.Author)
            .HasMaxLength(50)
            .HasColumnType("varchar(50)");
        
        builder
            .Property(b => b.Publisher)
            .HasMaxLength(50)
            .HasColumnType("varchar(50)");
    }
}