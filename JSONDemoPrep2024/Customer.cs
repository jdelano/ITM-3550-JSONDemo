using System;
namespace JSONDemoPrep2024
{
	public class Customer
	{
		public int CustomerId { get; set; }
		public string Name { get; set; } = default!;
		public List<Order> Orders { get; set; } = new();
	}
}

