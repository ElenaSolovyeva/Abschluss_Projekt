using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MaterialStatus.Domain.Entities;

namespace MaterialStatus.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>    
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User>Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Identity Roles
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "24bd68f9-29e2-4716-a600-2cb7520c17be",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2a0939b9-be39-4521-b246-5694728e0799",
                Name = "user",
                NormalizedName = "USER"
            });

            // Identity Users
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "04d0c04c-d0c1-4907-808a-468d26c5030a",
                UserName = "ThomasAnderson",
                NormalizedUserName = "THOMASANDERSON",
                Email = "thomas@email.com",
                NormalizedEmail = "THOMAS@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "thomas"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "60fdf05f-7335-4b70-aa5a-b52b6d9ccbd6",
                UserName = "LukeSkywalker",
                NormalizedUserName = "LUKESKYWALKER",
                Email = "luke@email.com",
                NormalizedEmail = "LUKE@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "luke"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "a562161f-9a68-444f-b0fb-8128d8968c6f",
                UserName = "HanSolo",
                NormalizedUserName = "HANSOLO",
                Email = "han@email.com",
                NormalizedEmail = "HAN@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "han"),
                SecurityStamp = string.Empty
            });

            // Zuweisung von Identity-Rollen

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "24bd68f9-29e2-4716-a600-2cb7520c17be", // admin
                UserId = "04d0c04c-d0c1-4907-808a-468d26c5030a" // ThomasAnderson
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2a0939b9-be39-4521-b246-5694728e0799", // user
                UserId = "60fdf05f-7335-4b70-aa5a-b52b6d9ccbd6" // LukeSkywalker
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2a0939b9-be39-4521-b246-5694728e0799", // user
                UserId = "a562161f-9a68-444f-b0fb-8128d8968c6f" // LukeSkywalker
            });
        }
    }
}
