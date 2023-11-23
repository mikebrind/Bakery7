namespace Bakery.Models;

public class Basket
{
    public List<OrderItem> Items { get; set; } = new ();
    public int NumberOfItems => Items.Sum(x => x.Quantity);
}