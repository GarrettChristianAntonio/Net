using PruebasUnitarias.Models;
using PruebasUnitarias.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaUnitaria.Tests.FakeRepositories
{
	internal class FakeProductRepository : IProductRepository
	{
		public IEnumerable<Product> GetProducts()
		{
			return new List<Product>()
			{
				new Product { Id = 1, Name = "Product1", BasePrice = 1.1F, Description = "Description for product 1"},
				new Product { Id = 2, Name = "Product2", BasePrice = 2.2F, Description = "Description for product 2"},
				new Product { Id = 3, Name = "Product3", BasePrice = 3.3F, Description = "Description for product 3"}
			};
		}

	}
}
