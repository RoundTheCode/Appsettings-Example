using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RoundTheCode.AppSettings.Entities;

namespace RoundTheCode.AppSettings
{
    public class AppSettingsDbContext : DbContext
    {
        public DbSet<Authentication> Authentication { get; private set; }

        public AppSettingsDbContext() : base()
        {

        }

        public AppSettingsDbContext(DbContextOptions<AppSettingsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Authentication>().HasKey(s => s.Id);
            builder.Entity<Authentication>().ToTable("Authentication");
        }
    }
}
