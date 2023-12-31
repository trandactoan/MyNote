using MyNote.Interface.Models.Accounts;

namespace MyNote.Domain.Interfaces.Boudaries.Accounts
{
    public interface ICreateAccount
    {
        public class Request
        {
            public CreateAccountRequestModel CreateAccountRequestModel { get; set; }
            public Request(CreateAccountRequestModel createAccountRequestModel)
            {
                CreateAccountRequestModel = createAccountRequestModel;
            }
        }
        public class Response
        {
            public CreateAccountResponseModel CreateAccountResponseModel { get; set; }
            public Response(CreateAccountResponseModel createAccountResponseModel)
            {
                CreateAccountResponseModel = createAccountResponseModel;
            }
        }
        public Task<Response> CreateAccountAsync(Request request);
    }
}
