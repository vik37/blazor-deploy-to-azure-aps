namespace BlazorDeployDemo.Models
{
	public class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int Count { get; set; }
		public bool IsVailable { get; set; } = false;

		public Product(string name, double price, int count = 0)
		{
			Name = name;
			Price = price;
			Count = count;
			IsVailable = Count > 0;
		}
	}
}
