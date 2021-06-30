using MarketingDeliveryModels.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDeliveryService
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car");
        }
    }
}
