namespace SportShop.Models;

public class Cart
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}