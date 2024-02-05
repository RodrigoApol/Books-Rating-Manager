using BooksRatingManager.Application.Commands.BookCommands.CreateBook;
using FluentValidation;

namespace BooksRatingManager.Application.Validators;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(b => b.Title)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50)
            .WithMessage("Title must contain a maximum of 50 characters");

        RuleFor(b => b.Author)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50)
            .WithMessage("Author must contain a maximum of 50 characters");

        RuleFor(b => b.ISBN)
            .NotEmpty()
            .NotNull()
            .MaximumLength(13)
            .MinimumLength(13)
            .WithMessage("ISBN must contain exactly 13 digits");

        RuleFor(b => b.YearPublication)
            .NotEmpty()
            .NotNull()
            .LessThanOrEqualTo(DateTime.Now.Year);

        RuleFor(b => b.Pages)
            .NotEmpty()
            .NotNull()
            .GreaterThan(0);
    }
}