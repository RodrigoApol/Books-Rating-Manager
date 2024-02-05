using BooksRatingManager.Application.Commands.UserCommands.CreateUser;
using FluentValidation;

namespace BooksRatingManager.Application.Validators;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(u => u.Name)
            .NotEmpty()
            .NotNull()
            .MaximumLength(50)
            .WithMessage("The name must have a maximum of a 50 characters!");

        RuleFor(u => u.Email)
            .NotEmpty()
            .NotNull()
            .EmailAddress()
            .WithMessage("The email does not follow the desired pattern");
    }
}