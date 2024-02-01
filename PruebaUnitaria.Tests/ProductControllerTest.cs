using Microsoft.AspNetCore.Mvc;
using PruebasUnitarias.Controllers;
using PruebasUnitarias.Models;
using PruebasUnitarias.Repositorios;
using PruebaUnitaria.Tests.FakeRepositories;

namespace PruebaUnitaria.Tests
{
	[TestClass]
	public class ProductControllerTest
	{
		[TestMethod]
		public void IndexModelShouldContainAllProducts()
		{
			IProductRepository fakeProductRepository = new FakeProductRepository();
			ProductController productController = new ProductController(fakeProductRepository);
			ViewResult viewResult = productController.Index() as ViewResult;
			List<Product> products = viewResult.Model as List<Product>;
			Assert.AreEqual(products.Count, 3);
		}
		[TestMethod]
		public void GetProductModelShouldContainTheRightProduct()
		{
			IProductRepository fakeProductRepository = new FakeProductRepository();
			ProductController productController = new ProductController(fakeProductRepository);
			ViewResult viewResult = productController.GetProducts(2) as ViewResult;
			Product product = viewResult.Model as Product;
			Assert.AreEqual(product.Id, 2);

		}
	}
}