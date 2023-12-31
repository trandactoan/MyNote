using MyNote.Domain.Models.Users;

namespace MyNote.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<CreateUserResponseModel> CreateUserAsync(CreateUserRequestModel request);
    }
}
