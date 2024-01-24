using BooksRatingManager.Application.Commands.BookCommands.CreateBook;
using BooksRatingManager.Application.Commands.BookCommands.DeleteBook;
using BooksRatingManager.Application.Commands.BookCommands.UpdateBook;
using BooksRatingManager.Application.Commands.BookCommands.UploadCoverBook;
using BooksRatingManager.Application.Queries.BookQueries.GetAllBooks;
using BooksRatingManager.Application.Queries.BookQueries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BooksRatingManager.API.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IMediator _mediator;

    public BooksController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllBooksQuery();
        
        var books = await _mediator.Send(query);
        
        return Ok(books);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var query = new GetBookByIdQuery(id);

        var book = await _mediator.Send(query);
        
        return Ok(book);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateBookCommand command)
    {
        var id = await _mediator.Send(command);
        
        return CreatedAtAction(
            nameof(GetById),
            new { id = id },
            command
        );
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(UpdateBookCommand command)
    {
        await _mediator.Send(command);
        
        return NoContent();
    }

    [HttpPut("Upload/{id}")]
    public async Task<IActionResult> Upload(IFormFile cover, int id)
    {
        var command = new UploadCoverBookCommand(id, cover);

        await _mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var command = new DeleteBookCommand(id);
        
        await _mediator.Send(command);
        
        return NoContent();
    }
}