using MyNote.Domain.Models.Users;

namespace MyNote.API.Dtos.Users
{
    public class CreateUserRequest
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? TimeZone { get; set; }
        public CreateUserRequestModel ToModel()
        {
            return new CreateUserRequestModel
            {
                Id = Guid.NewGuid().ToString(),
                Name = FirstName + " " + LastName,
                LastName = LastName,
                FirstName = FirstName,
                CreatedDate = DateTime.UtcNow,
                LastModifiedDate = DateTime.UtcNow,
                TimeZone = TimeZone
            };
        }
    }
}
