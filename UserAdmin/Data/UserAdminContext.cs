using Microsoft.EntityFrameworkCore;
using UserAdmin.Data.Entities;

namespace UserAdmin.Data
{
    public class UserAdminContext : DbContext
    {
        public UserAdminContext(DbContextOptions<UserAdminContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasKey(u => new { u.Id });
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>(entity => {
                entity.Property(e => e.Users).HasColumnType("varchar(255)");
                entity.Property(e => e.Mail).HasColumnType("varchar(255)");
                entity.Property(e => e.Password).HasColumnType("varchar(255)");
                entity.Property(e => e.Sex).HasColumnType("varchar(255)");
                entity.Property(e => e.Status).HasColumnType("bit");
                });

            modelBuilder.Entity<User>()
                .HasData(new User()
                {
                    Id= 2,
                    Users = "Fulanito Ramirez",
                    Mail = "hey@gmail.com",
                    Sex = "Male",
                    Password = "Ey1234567890!",
                    Status = true                    
                });

        }

    }
}
