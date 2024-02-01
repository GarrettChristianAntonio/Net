using Microsoft.EntityFrameworkCore;
using Sql_Lite.Models;
namespace Sql_Lite.Data
{
	public class PersonContext:DbContext
	{
		public PersonContext(DbContextOptions<PersonContext> options) : base() 
		{ 

		}
		public DbSet<Person> People { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Person>().HasData(
				new Person()
				{
					PersonId = 1,
					FirstName = "Juan",
					LastName = "Perez",
					City = "Buenos Aires",
					Address = "Cramer 1653"
				},
				new Person()
				{
					PersonId = 2,
					FirstName = "Maria",
					LastName = "Lala",
					City = "Buenos Aires capital",
					Address = "Crame 01"
				},
				new Person()
				{
					PersonId = 3,
					FirstName = "Juanito",
					LastName = "PerezRato",
					City = "Buenos Mares",
					Address = "Lavalle 5533"
				});
		}
	}
}
