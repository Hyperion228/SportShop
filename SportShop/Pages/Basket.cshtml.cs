using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;

namespace SportShop.Pages;

public class Basket : PageModel
{
    public string Message { get; private set; } = "";
    ApplicationContext _context;
    public List<Cart> BasketItems { get;private set; } = new();
    public Basket(ApplicationContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        BasketItems = _context.BasketItems.ToList();
    }
}