using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Application> Applications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().HasKey(x => x.Id);
            modelBuilder.Entity<Application>().HasData(
                new Application
                {
                    College = College.ENU,
                    Iin = "1516",
                    Score = 125,
                    Profile1 = Profile.biology,
                    Profile2 = Profile.literature,
                    Id = 1
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}