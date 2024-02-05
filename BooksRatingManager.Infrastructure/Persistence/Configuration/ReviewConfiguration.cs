using BooksRatingManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksRatingManager.Infrastructure.Persistence.Configuration;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder
            .HasKey(r => r.Id);

        builder
            .HasOne(r => r.Book)
            .WithMany()
            .HasForeignKey(r => r.IdBook)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.IdUser)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(r => r.Description)
            .HasMaxLength(200)
            .HasColumnType("varchar(200)");
    }
}