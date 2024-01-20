using BooksRatingManager.Application.Commands.UserCommands.CreateUser;
using BooksRatingManager.Application.Commands.UserCommands.UpdateUser;
using BooksRatingManager.Application.Queries.BookQueries.GetById;
using BooksRatingManager.Application.Queries.UserQueries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BooksRatingManager.API.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllUsersQuery();
        
        var users = await _mediator.Send(query);

        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var query = new GetBookByIdQuery(id);

        var user = await _mediator.Send(query);

        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateUserCommand command)
    {
        var userId = await _mediator.Send(command);

        return CreatedAtAction(
            nameof(GetById),
            new { id = userId },
            command);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(UpdateUserCommand command, int id)
    {
        await _mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(id);

        return NoContent();
    }
}