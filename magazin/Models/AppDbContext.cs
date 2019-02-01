using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace shop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<shop.Models.Produs> Produs { get; set; }
        public DbSet<shop.Models.Client> Client { get; set; }
        public DbSet<shop.Models.Cos> Cos { get; set; }
    }
}