using BooksRatingManager.Application.Models.MappingViewModels;
using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Queries.UserQueries.GetUserById;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery ,UserDetailsViewModel>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<UserDetailsViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetDetailsAsync(request.Id);

        return user.ToViewModelWithId();
    }
}