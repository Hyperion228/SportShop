using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;


namespace SportShop.Pages;

public class Catalog : PageModel
{
    ApplicationContext _context;
    public string Message { get; set; } = "";
    public List<Product> Products { get; private set; } = new();

    public Catalog(ApplicationContext context)
    {
        _context = context;
    }

    public IActionResult OnPost(int productId,string productName, int price)
    {
        var basket = new Cart
        {
            ProductId = productId,
            Title = productName,
            Price = price
        };
        // var cart = _context.BasketItems.FirstOrDefault(b => b.ProductId == productId && b.Title == productName && b.Price == price);
        _context.BasketItems.Add(basket);
        _context.SaveChanges();
        Message = "Товар добавлен в корзину";
        return Page();
    }
    public void OnGet()
    {
        Products = _context.Products.ToList();
    }
}