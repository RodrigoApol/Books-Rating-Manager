using BooksRatingManager.Application.Commands.ReviewsCommands.CreateReview;
using FluentValidation;

namespace BooksRatingManager.Application.Validators;

public class CreateReviewCommandValidator : AbstractValidator<CreateReviewCommand>
{
    public CreateReviewCommandValidator()
    {
        RuleFor(r => r.Description)
            .MaximumLength(200)
            .WithMessage("Description must contain a maximum of 200 characters");
    }
}