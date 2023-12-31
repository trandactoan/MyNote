namespace MyNote.Interface.Models.Accounts
{
    public class CreateAccountResponseModel
    {
        public string Id { get; set; } = string.Empty;
        public CreateAccountResponseModel(string id) { 
            Id = id;
        }
    }
}
