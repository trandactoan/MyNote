using MyNote.Domain.Entities;

namespace MyNote.Interface.Models.Accounts
{
    public class CreateAccountRequestModel
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public Account ToEntity()
        {
            return new Account
            {
                Id = Id,
                Name = Name,
                Password = Password,
                Email = Email
            };
        }
    }
}