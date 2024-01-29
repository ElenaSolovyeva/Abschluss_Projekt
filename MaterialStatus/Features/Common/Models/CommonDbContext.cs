using System;
//using MaterialStatus.Features.SWG.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialStatus.Features.Common.Models
{
    public class CommonDbContext : DbContext
    {
        public DbSet<tbl_equipement_dosier> tbl_equipement_dosier { get; set; }

        public CommonDbContext(DbContextOptions<CommonDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // without migration
        }
    }
}
