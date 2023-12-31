using MyNote.Domain.Entities;
using MyNote.Domain.Interfaces.Repositories;

namespace MyNote.Repository.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(MyNoteDbContext context) : base(context)
        {
        }
    }
}
