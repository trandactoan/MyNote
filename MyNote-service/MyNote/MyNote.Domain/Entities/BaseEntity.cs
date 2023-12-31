namespace MyNote.Domain.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; } = string.Empty;
        public string? Name { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
