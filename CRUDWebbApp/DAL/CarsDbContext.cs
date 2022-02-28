using CRUDWebbApp.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebbApp.DAL
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne<Make>(c => c.Make)
                .WithMany(m => m.CarModels)
                .HasForeignKey(c => c.MakeId);
            modelBuilder.Entity<Dealer>()
                .HasMany<Car>(d => d.Stock)
                .WithMany(c => c.Dealers);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Dealer> Dealerships { get; set; }
    }
}
