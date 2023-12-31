using Microsoft.AspNetCore.Mvc;
using MyNote.API.Dtos.Accounts;
using MyNote.Domain.Interfaces.Boudaries.Accounts;

namespace MyNote.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly ICreateAccount _createAccount = null!;
        public AccountController(ICreateAccount createAccount)
        {
            _createAccount = createAccount;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateAccountResponse))]
        public async Task<IActionResult> CreateAccountAsync(CreateAccountRequest request)
        {
            var requestModel = request.ToModel();
            var interactorResponse = await _createAccount.CreateAccountAsync(new ICreateAccount.Request(requestModel));
            return new CreatedResult(nameof(CreateAccountAsync), CreateAccountResponse.FromModel(interactorResponse.CreateAccountResponseModel));
        }
    }
}
