using BooksRatingManager.Application.Commands.ReviewsCommands.CreateReview;
using BooksRatingManager.Application.Queries.ReviewsQueries.GetReviewsByBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BooksRatingManager.API.Controllers;

[Route("api/reviews")]
[ApiController]
public class ReviewsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReviewsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var query = new GetReviewsByBookQuery(id);

        var reviews = await _mediator.Send(query);
        
        return Ok(reviews);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateReviewCommand command)
    {
        var reviewId = await _mediator.Send(command);

        return CreatedAtAction(
            nameof(GetById),
            new { id = reviewId },
            command);
    }
}