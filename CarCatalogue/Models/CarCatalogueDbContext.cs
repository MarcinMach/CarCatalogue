using Microsoft.EntityFrameworkCore;

namespace CarCatalogue.Models
{
    public class CarCatalogueDbContext : DbContext
    {
        public CarCatalogueDbContext(DbContextOptions<CarCatalogueDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);
        }

    }

}
