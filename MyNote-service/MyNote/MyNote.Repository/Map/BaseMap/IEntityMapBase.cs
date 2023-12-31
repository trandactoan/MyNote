using Microsoft.EntityFrameworkCore;

namespace MyNote.Repository.Map.BaseMap
{
    public interface IEntityMapBase<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
    {
    }
}
