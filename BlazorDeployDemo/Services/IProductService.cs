using BlazorDeployDemo.Models;

namespace BlazorDeployDemo.Services
{
	public interface IProductService
	{
		List<Product> GetProducts();
	}
}
