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
    }
}