using BooksRatingManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksRatingManager.Infrastructure.Persistence.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(u => u.Id);

        builder
            .HasMany(u => u.Reviews)
            .WithOne(r => r.User)
            .HasForeignKey(r => r.IdUser)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(u => u.Name)
            .HasMaxLength(50)
            .HasColumnType("varchar(50)");

        builder
            .Property(u => u.Email)
            .HasMaxLength(50)
            .HasColumnType("varchar(50)");
    }
}