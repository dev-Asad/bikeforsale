using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bikeforsale.Models;
using Microsoft.EntityFrameworkCore;

namespace bikeforsale.AppDbContext
{
    public class BikeForSaleDbContext : DbContext
    {
        public BikeForSaleDbContext(DbContextOptions<BikeForSaleDbContext> options):base(options)
        {

        }
        public DbSet<Make> makes { get; set; }
        public DbSet<Model> models { get; set; }
    }
}
