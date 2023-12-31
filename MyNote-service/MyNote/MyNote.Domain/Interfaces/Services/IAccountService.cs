using MyNote.Interface.Models.Accounts;

namespace MyNote.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        Task<CreateAccountResponseModel> CreateNewAccountAsync(CreateAccountRequestModel requestModel);
    }
}
