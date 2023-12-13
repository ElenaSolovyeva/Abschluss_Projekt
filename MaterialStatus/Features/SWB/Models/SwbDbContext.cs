using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaterialStatus.Features.SWB.Models
{
    public class SwbDbContext : DbContext
    {
        public DbSet<tbl_dispo> tbl_dispo { get; set; }
        
        public SwbDbContext(DbContextOptions<SwbDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // without migration
        }

    }
}
