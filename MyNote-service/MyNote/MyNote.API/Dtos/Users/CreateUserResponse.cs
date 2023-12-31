using MyNote.Domain.Models.Users;

namespace MyNote.API.Dtos.Users
{
    public class CreateUserResponse
    {
        public string NewUserId { get; set; } = null!;
        public static CreateUserResponse FromModel(CreateUserResponseModel responseModel)
        {
            return new CreateUserResponse
            {
                NewUserId = responseModel.NewUserId,
            };
        }
    }
}
