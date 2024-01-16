using BooksRatingManager.Core.Entities;
using BooksRatingManager.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace BooksRatingManager.API.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly BooksRatingManagerDbContext _dbContext;

    public BooksController(BooksRatingManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        var books = _dbContext.Books;
        
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var book = _dbContext.Books.SingleOrDefault(b => b.Id == id);
        
        return Ok(book);
    }

    [HttpPost]
    public IActionResult Post(Book book)
    {
        _dbContext.Books.Add(book);
        
        return CreatedAtAction(
            nameof(GetById),
            new { id = book.Id },
            book
        );
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Book book)
    {
        var bookExists = _dbContext.Books.SingleOrDefault(b => b.Id == id);

        if (bookExists is null)
        {
            return NotFound();
        }

        bookExists.UpdateBook(book.Title, book.Description, book.Author, book.YearPublication);
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var bookExists = _dbContext.Books.SingleOrDefault(b => b.Id == id);

        if (bookExists is null)
        {
            return NotFound();
        }

        _dbContext.Books.Remove(bookExists);
        
        return NoContent();
    }
}