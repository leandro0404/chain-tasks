using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Chain
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,11433;Database=Teste;User Id=sa;Password=heart_beat_user;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


           
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<Processed> Processed { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<User> User { get; set; }
    }
}
