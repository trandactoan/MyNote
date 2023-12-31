using MyNote.Domain.Interfaces.Boudaries.Accounts;
using MyNote.Domain.Interfaces.Services;

namespace MyNote.Domain.Interactor.Accounts
{
    public class CreateAccount : ICreateAccount
    {
        private readonly IAccountService _accountsService;
        public CreateAccount(IAccountService accountsService)
        {
            _accountsService = accountsService;
        }

        public async Task<ICreateAccount.Response> CreateAccountAsync(ICreateAccount.Request request)
        {
            var result = await _accountsService.CreateNewAccountAsync(request.CreateAccountRequestModel);
            return new ICreateAccount.Response(result);
        }
    }
}
