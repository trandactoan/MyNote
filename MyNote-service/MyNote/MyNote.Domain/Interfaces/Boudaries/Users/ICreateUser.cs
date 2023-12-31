using MyNote.Domain.Models.Users;

namespace MyNote.Domain.Interfaces.Boudaries.Users
{
    public interface ICreateUser
    {
        public class Request
        {
            public CreateUserRequestModel CreateUserResponseModel { get; set; }
            public Request(CreateUserRequestModel createUserRequestModel) {
                CreateUserResponseModel = createUserRequestModel;
            }
        }
        public class Response
        {
            public CreateUserResponseModel CreateUserResponseModel { get; set; }
            public Response(CreateUserResponseModel createUserResponseModel)
            {
                CreateUserResponseModel = createUserResponseModel;
            }
        }
        Task<Response> CreateUserAsync(Request request);
    }
}
