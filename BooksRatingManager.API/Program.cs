using BooksRatingManager.Application.Commands.BookCommands.CreateBook;
using BooksRatingManager.Core.Repositories;
using BooksRatingManager.Infrastructure.Persistence;
using BooksRatingManager.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BooksRatingManagerDbContext>(
    o => o.UseInMemoryDatabase("BooksRatingManager"));

builder.Services.AddScoped<IBookRepository, BookRepository>();


builder.Services.AddMediatR(op => op.RegisterServicesFromAssemblyContaining(typeof(CreateBookCommand)));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

