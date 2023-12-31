using MyNote.Domain.Interfaces.Repositories;
using MyNote.Domain.Interfaces.Services;
using MyNote.Interface.Models.Accounts;

namespace MyNote.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository) {
            _accountRepository = accountRepository;
        }
        public async Task<CreateAccountResponseModel> CreateNewAccountAsync(CreateAccountRequestModel requestModel)
        {
            var entity = requestModel.ToEntity();
            var newEntity = await _accountRepository.CreateAsync(entity, true);
            return new CreateAccountResponseModel(newEntity.Id);
        }
    }
}
