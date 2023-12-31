using Microsoft.AspNetCore.Mvc;
using MyNote.API.Dtos.Users;
using MyNote.Domain.Interfaces.Boudaries.Users;

namespace MyNote.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly ICreateUser _createUser = null!;
        public UserController(
            ICreateUser createUser) {
            _createUser = createUser;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateUserResponse))]
        public async Task<IActionResult> CreateUserAsync(CreateUserRequest request)
        {
            var requestModel = request.ToModel();
            var requestInteractor = new ICreateUser.Request(requestModel);
            var interactorResponse = await _createUser.CreateUserAsync(requestInteractor);
            return new CreatedResult(nameof(CreateUserAsync), CreateUserResponse.FromModel(interactorResponse.CreateUserResponseModel));
        }
    }
}
