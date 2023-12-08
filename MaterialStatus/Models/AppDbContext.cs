using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaterialStatus.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>    
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated(); // without migration
        }

        public DbSet<Dispo> Dispos { get; set; }
        
    }
}
