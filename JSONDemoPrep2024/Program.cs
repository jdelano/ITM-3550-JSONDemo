using System.Text.Json;

namespace JSONDemoPrep2024;

class Program
{
    static void Main(string[] args)
    {
        var order1 = new Order { OrderId = 1, OrderDate = DateTime.Now };
        var order2 = new Order { OrderId = 2,
            OrderDate = DateTime.Now - TimeSpan.FromDays(90) };

        var customer = new Customer {
            CustomerId = 1,
            Name = "Bob Smith",
            Orders = { order1, order2 }
        };

        var json = JsonSerializer.Serialize(customer);
        Console.WriteLine(json);

        string orderJson = """
            {
                "CustomerId" : 1,
                "Name": "Bob Smith",
                "Orders": [
                    {
                        "OrderId": 1,
                        "OrderDate": "2024-04-22"
                    },
                    {
                        "OrderId": 2,
                        "OrderDate": "2024-01-22"
                    }
                ]
            }
            """;
        var bob = JsonSerializer.Deserialize<Customer>(orderJson);
        if (bob is not null)
        {
            Console.WriteLine($"ID: {bob.CustomerId}");
            Console.WriteLine($"Name: {bob.Name}");
            Console.WriteLine($"Number of Orders: {bob.Orders.Count}");
        }
    }
}

