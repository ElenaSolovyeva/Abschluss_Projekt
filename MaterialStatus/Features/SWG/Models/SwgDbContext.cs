using System;
using Microsoft.EntityFrameworkCore;

namespace MaterialStatus.Features.SWG.Models
{
    public class SwgDbContext : DbContext
    {
        public DbSet<tbl_dispo> tbl_dispo { get; set; }
        public DbSet<tbl_dispo> tbl_lager { get; set; }

        public SwgDbContext(DbContextOptions<SwgDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // without migration
        }

    }
}
