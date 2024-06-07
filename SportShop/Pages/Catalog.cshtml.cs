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

    public void OnPost(int productId,string productName, int price)
    {
        var basket = new Cart
        {
            ProductId = productId,
            Title = productName,
            Price = price
        };
        foreach (var item in _context.BasketItems)
        {
            if (productId == item.ProductId)
            {
                Message = "Такой товар уже есть в корзине";
                return;
            }
        }
        _context.BasketItems.Add(basket);
        _context.SaveChanges();
        Message = "Товар добавлен в корзину";
        //return Page();
    }
    public void OnGet()
    {
        Message = "Выберите товар";
        Products = _context.Products.ToList();
    }
}