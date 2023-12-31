using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNote.Domain.Entities;

namespace MyNote.Repository.Map.BaseMap
{
    public class EntityBaseMap<TEntity> : IEntityMapBase<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName("ID")
                   .IsRequired()
                   .HasMaxLength(36);

            builder.Property(e => e.Name)
                   .HasMaxLength(255)
                   .IsUnicode();

            builder.Property(e => e.IsDeleted)
                .HasColumnName("IsDeleted")
                .HasDefaultValue(false);
        }
    }
}
