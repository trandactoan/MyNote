using MyNote.Domain.Entities;

namespace MyNote.Domain.Models.Users
{
    public class CreateUserRequestModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? TimeZone { get; set; }
        public User ToEntity()
        {
            return new User
            {
                Id = Id,
                Name = Name,
                LastName = LastName,
                FirstName = FirstName,
                CreatedDate = CreatedDate,
                LastModifiedDate = LastModifiedDate,
                TimeZone = TimeZone,
            };
        }
    }
}
