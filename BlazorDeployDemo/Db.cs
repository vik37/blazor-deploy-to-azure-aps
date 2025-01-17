using BlazorDeployDemo.Models;

namespace BlazorDeployDemo
{
	public static class Db
	{
		public static List<Product> Products = new List<Product>();

		public static void Inital()
		{
			if(Products.Count == 0)
			{
				Products.Add(new Product(name: "Nike Sneakers", price: 12, count: 2));
				Products.Add(new Product(name: "Planika Boots", price: 27, count: 7));
				Products.Add(new Product(name: "Parachute Classic Slippers", price: 8, count: 0));
				Products.Add(new Product(name: "Converse Seakers", price: 6.25, count: 12));
			}
		}
	}
}
