using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaterialStatus.Features.SWG.Models
{
    public class SwgDbContext : DbContext
    {
        public DbSet<tbl_dispo> tbl_dispo { get; set; }
        //public DbSet<DispoG> DisposG { get; set; }

        public SwgDbContext(DbContextOptions<SwgDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // without migration
        }

    }
}
