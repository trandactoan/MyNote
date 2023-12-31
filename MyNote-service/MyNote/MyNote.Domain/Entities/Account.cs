namespace MyNote.Domain.Entities
{
    public class Account : BaseEntity
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}