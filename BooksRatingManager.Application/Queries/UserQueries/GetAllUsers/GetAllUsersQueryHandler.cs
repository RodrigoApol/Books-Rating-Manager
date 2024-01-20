using BooksRatingManager.Application.Models.MappingViewModels;
using BooksRatingManager.Application.Models.ViewModels;
using BooksRatingManager.Core.Repositories;
using MediatR;

namespace BooksRatingManager.Application.Queries.UserQueries.GetAll;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserViewModel>>
{
    private readonly IUserRepository _userRepository;

    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<List<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync();

        return users.ToViewModel().ToList();
    }
}