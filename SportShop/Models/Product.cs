namespace SportShop.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string ImageUrl { get; set; }
    public int Count { get; set; }
}