using MyNote.Domain.Interfaces.Repositories;

namespace MyNote.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public void Dispose()
        {
        }
    }
}
