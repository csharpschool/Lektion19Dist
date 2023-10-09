namespace Lektion19Dist.Classes;

public class Order
{
    public int Id { get; set; }

    public void AddOrderRow()
    {
        Product product = new Product();
        OrderRow row = new OrderRow();
        row.Vat = 0.25;
        row.Total = product.Price;
    }
}

public class OrderRow
{
    public int Id { get; set; }
    public double Vat { get; set; }

    double _total = 0;
    public double Total {
        get { return _total; }
        set { _total = value * Vat; }
    }
}

public class Product
{
    public int Id { get; set; }
    public double Price { get; set; }
}
