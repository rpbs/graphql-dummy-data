using Microsoft.EntityFrameworkCore;

namespace graphql_dummy_data.Entity
{
    public class GraphQLContext : DbContext
    {
        public GraphQLContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>()
                .HasKey(b => b.Id);

            var brands = new List<Brand>(){
                new Brand() { Id = 1, Country = "DE", Name = "Gol" },
                new Brand() { Id = 2, Country = "DE", Name = "BMW" },
                new Brand() { Id = 3, Country = "DE", Name = "Audi" }
            };



            modelBuilder.Entity<Brand>().HasData(brands);

            modelBuilder.Entity<Car>().HasData(
              new Car() { Id = 1, Name = "Gol", Description = "asd", Price = 100.5m, BrandId = 1 },
              new Car() { Id = 2, Name = "BMW", Description = "another german", Price = 110.5m, BrandId = 2 },
              new Car() { Id = 3, Name = "Audi", Description = "nice one", Price = 200.5m, BrandId = 3 }
            );

            modelBuilder.Entity<Car>()
                .Property(b => b.Price)
                .HasPrecision(18);

            modelBuilder.Entity<Car>()
                .HasKey(b => b.Id);
        }
    }
}
