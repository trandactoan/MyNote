using MyNote.Domain.Interfaces.Boudaries.Users;
using MyNote.Domain.Interfaces.Services;

namespace MyNote.Domain.Interactors.Users
{
    public class CreateUser : ICreateUser
    {
        private readonly IUserService _userService;
        public CreateUser(IUserService userService) { 
            _userService = userService;
        }

        public async Task<ICreateUser.Response> CreateUserAsync(ICreateUser.Request request)
        {
            var result = await _userService.CreateUserAsync(request.CreateUserResponseModel);
            return new ICreateUser.Response(result);
        }
    }
}
