using MyNote.Interface.Models.Accounts;

namespace MyNote.API.Dtos.Accounts
{
    public class CreateAccountRequest
    {
        public string? Namex { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public CreateAccountRequestModel ToModel()
        {
            return new CreateAccountRequestModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = Namex,
                Email = Email,
                Password = Password
            };
        }
    }
}
