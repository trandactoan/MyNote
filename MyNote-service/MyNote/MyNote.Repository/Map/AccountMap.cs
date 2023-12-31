using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNote.Domain.Entities;
using MyNote.Repository.Map.BaseMap;

namespace MyNote.Repository.Map
{
    public class AccountMap : EntityBaseMap<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            base.Configure(builder);

            builder.ToTable("ACCOUNT");

            builder.Property(e => e.Email)
                 .HasMaxLength(255)
                 .HasDefaultValue("")
                 .IsUnicode(false);

            builder.Property(e => e.Password)
                 .HasMaxLength(255)
                 .IsUnicode(false);
        }
    }
}
