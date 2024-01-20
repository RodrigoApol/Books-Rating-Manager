using MediatR;

namespace BooksRatingManager.Application.Commands.ReviewsCommands.CreateReview;

public class CreateReviewCommand : IRequest<int>
{
    public CreateReviewCommand(int rating, string description, int idUser, int idBook)
    {
        Rating = rating;
        Description = description;
        IdUser = idUser;
        IdBook = idBook;
    }

    public int Rating { get; set; }
    public string Description { get; set; }
    public int IdUser { get; set; }
    public int IdBook { get; set; }
}