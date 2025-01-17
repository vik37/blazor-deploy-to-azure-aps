using BlazorDeployDemo.Models;

namespace BlazorDeployDemo.Services
{
	public class ProductService : IProductService
	{
		public ProductService()
		{
			Db.Inital();
		}
		public List<Product> GetProducts()
		{
			return Db.Products;
		}
	}
}
