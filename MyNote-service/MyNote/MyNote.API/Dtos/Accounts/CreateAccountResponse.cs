using MyNote.Interface.Models.Accounts;

namespace MyNote.API.Dtos.Accounts
{
    public class CreateAccountResponse
    {
        public string Id { get; set; } = null!;
        public static CreateAccountResponse FromModel(CreateAccountResponseModel model)
        {
            return new CreateAccountResponse { Id = model.Id, };
        }
    }
}
