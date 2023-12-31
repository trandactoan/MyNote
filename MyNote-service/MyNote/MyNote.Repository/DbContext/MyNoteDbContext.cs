using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyNote.Domain.Entities;
using MyNote.Repository.Map;

namespace MyNote.Repository
{
    public class MyNoteDbContext : DbContext
    {
        public static readonly ILoggerFactory loggerFactory = new LoggerFactory();
        public MyNoteDbContext(DbContextOptions<MyNoteDbContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new AccountMap());
        }
    }
}
