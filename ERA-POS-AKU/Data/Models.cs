namespace ERA_POS_AKU.Data;

public class Product
{
    public string Barcode { get; set; }
    public List<string> AlternateBarcodes { get; set; } = new List<string>();
    public string AlternateBarcode { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Tax { get; set; }
    public int Stock { get; set; }
    public bool Subsidized { get; set; }
    public double SubsidizedPrice { get; set; }
}

public class CartItem
{
    public Product Product { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public double Total { get; set; }
}

public class Payment
{
    public string Method { get; set; }
    public double Amount { get; set; }
}

public class Customer
{
    public string Name { get; set; }
    public string Identity { get; set; }
    public CustomerType Type { get; set; }
    public double Balance { get; set; }
}

public enum CustomerType
{
    Employee,
    Student,
    PrePay
}