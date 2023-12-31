namespace MyNote.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string? TimeZone { get; set; }
    }
}
