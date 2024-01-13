using BooksRatingManager.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BooksRatingManager.API.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController : ControllerBase
{
    
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Post(Book book)
    {
        return CreatedAtAction(
            nameof(GetById),
            new { id = book.Id },
            book
        );
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Book book)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
}