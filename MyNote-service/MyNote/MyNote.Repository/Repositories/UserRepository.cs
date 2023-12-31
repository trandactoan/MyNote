using MyNote.Domain.Entities;
using MyNote.Domain.Interfaces.Repositories;

namespace MyNote.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MyNoteDbContext context) : base(context)
        {
        }
    }
}
