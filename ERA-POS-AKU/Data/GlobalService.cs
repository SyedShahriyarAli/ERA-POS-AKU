namespace ERA_POS_AKU.Data;

public class GlobalService
{
    public Task<List<Product>> GetProducts()
    {
        List<Product> foodItems = new List<Product>
        {
            new Product { Barcode = "P01", Name = "Banana", Description = "Fresh and ripe banana", Price = 55.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0, AlternateBarcodes = new List<string>(){ "P001", "P0001" } },
            new Product { Barcode = "P02", Name = "Apple", Description = "Crisp and juicy apple", Price = 60.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 50 },
            new Product { Barcode = "P03", Name = "Chk.Wngs", Description = "Lean and protein-rich", Price = 200.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P04", Name = "Salmn.Fillet", Description = "Premium quality salmon", Price = 300.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 250 },
            new Product { Barcode = "P05", Name = "Quinoa", Description = "Nutrient-packed quinoa", Price = 80.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P06", Name = "Sandwich", Description = "Classic turkey club sandwich", Price = 120.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 80 },
            new Product { Barcode = "P07", Name = "Beverage", Description = "Refreshing green tea", Price = 30.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P08", Name = "Pasta", Description = "Creamy Alfredo pasta", Price = 150.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P09", Name = "Smoothie", Description = "Mixed berry blast smoothie", Price = 70.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 40 },
            new Product { Barcode = "P10", Name = "Salad", Description = "Classic Caesar salad", Price = 90.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P11", Name = "Pizza", Description = "Traditional Margherita pizza", Price = 180.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 120 },
            new Product { Barcode = "P12", Name = "Burrito", Description = "Spicy chicken burrito", Price = 110.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P13", Name = "Sushi", Description = "Delicious salmon roll sushi", Price = 250.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 200 },
            new Product { Barcode = "P14", Name = "Soup", Description = "Homemade tomato basil soup", Price = 45.0, Tax = 13, Stock = 100, Subsidized = false, SubsidizedPrice = 0 },
            new Product { Barcode = "P15", Name = "Ice.Crm", Description = "Creamy vanilla ice cream", Price = 60.0, Tax = 13, Stock = 100, Subsidized = true, SubsidizedPrice = 30 }
        };

        return Task.FromResult(foodItems);
    }

    public Task<List<Customer>> GetCustomers()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "John Doe", Identity = "123456789", Type = CustomerType.Employee, Balance = 5000 },
            new Customer { Name = "Jane Smith", Identity = "213456789", Type = CustomerType.Employee, Balance = 50 },
            new Customer { Name = "Bob Johnson", Identity = "132456789", Type = CustomerType.PrePay, Balance = 1000 },
            new Customer { Name = "Alice Williams", Identity = "124356789", Type = CustomerType.Employee, Balance = 2000 },
            new Customer { Name = "Charlie Brown", Identity = "123546789", Type = CustomerType.PrePay, Balance = 3000 },
            new Customer { Name = "Eva Davis", Identity = "123465789", Type = CustomerType.PrePay, Balance = 7853 },
            new Customer { Name = "Frank Miller", Identity = "123457689", Type = CustomerType.Employee, Balance = 2000 },
            new Customer { Name = "Grace Wilson", Identity = "123456879", Type = CustomerType.Employee, Balance = 998 },
            new Customer { Name = "David Lee", Identity = "123456798", Type = CustomerType.PrePay, Balance = 4000 },
            new Customer { Name = "Sophia Brown", Identity = "213546789", Type = CustomerType.Employee, Balance = 3500 }
        };


        return Task.FromResult(customers);
    }
}

