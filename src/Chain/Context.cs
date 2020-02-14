using Microsoft.EntityFrameworkCore;

namespace Chain
{
    public class Context : DbContext
    {
        public Context()
        {         

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Teste;User Id=heart_beat_user;Password=heart_beat_user;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDevice>()
            .HasKey(bc => new { bc.UserId, bc.DeviceId });
            modelBuilder.Entity<UserDevice>()
            .HasOne(bc => bc.User)
            .WithMany(b => b.UserDevices)
            .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserDevice>()
            .HasOne(bc => bc.Device)
            .WithMany(c => c.UserDevices)
            .HasForeignKey(bc => bc.DeviceId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> User { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
