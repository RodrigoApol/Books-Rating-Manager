using BooksRatingManager.Core.Entities;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.UserCommands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IUserRepository _userRepository;

    public CreateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User(request.Name, request.Email);

        await _userRepository.CreateUserAsync(user);
        await _userRepository.SaveChangesAsync();

        return user.Id;
    }
}