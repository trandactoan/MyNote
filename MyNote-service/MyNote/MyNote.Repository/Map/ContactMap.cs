using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNote.Domain.Entities;
using MyNote.Repository.Map.BaseMap;

namespace MyNote.Repository.Map
{
    public class UserMap : EntityBaseMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.ToTable("USER");

            builder.Property(e => e.Name)
                .IsUnicode()
                .HasMaxLength(512);

            builder.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode();

            builder.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode();

            builder.Property(e => e.LastModifiedDate)
                .HasColumnType("date");

            builder.Property(e => e.CreatedDate)
                .HasColumnType("date");
        }
    }
}
