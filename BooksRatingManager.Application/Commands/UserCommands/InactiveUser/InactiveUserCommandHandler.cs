using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Commands.UserCommands.InactiveUser;

public class InactiveUserCommandHandler : IRequestHandler<InactiveUserCommand, Unit>
{
    private readonly IUserRepository _userRepository;

    public InactiveUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<Unit> Handle(InactiveUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetDetailsAsync(request.Id);
        
        user.InactiveUser();
        await _userRepository.SaveChangesAsync();

        return Unit.Value;
    }
}