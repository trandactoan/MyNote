using MyNote.Domain.Interfaces.Repositories;
using MyNote.Domain.Interfaces.Services;
using MyNote.Domain.Models.Users;

namespace MyNote.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<CreateUserResponseModel> CreateUserAsync(CreateUserRequestModel request)
        {
            var entity = request.ToEntity();
            var newEntity = await _userRepository.CreateAsync(entity, true);
            return new CreateUserResponseModel { NewUserId = newEntity.Id };
        }
    }
}
