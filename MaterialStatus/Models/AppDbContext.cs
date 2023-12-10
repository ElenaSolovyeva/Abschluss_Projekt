using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaterialStatus.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<DispoB> DisposB { get; set; }
        public DbSet<DispoG> DisposG { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
            Database.EnsureCreated(); // without migration
        }       

    }
}
