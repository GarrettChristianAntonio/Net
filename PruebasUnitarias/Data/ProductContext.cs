using Microsoft.EntityFrameworkCore;
using PruebasUnitarias.Models;

namespace PruebasUnitarias.Data
{
	public class ProductContext : DbContext
	{
		public ProductContext(DbContextOptions<ProductContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Name = "Black",
					BasePrice = 5.5F,
					Description = "Description Black",
					ImageName = "Black"
				},
				new Product
				{
					Id = 2,
					Name = "BlueMorpho",
					BasePrice = 5.5F,
					Description = "Description2 BlueMorpho",
					ImageName = "BlueMorpho"
				}
				);
		}
	}
}
