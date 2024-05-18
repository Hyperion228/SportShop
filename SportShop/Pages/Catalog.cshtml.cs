using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;

namespace SportShop.Pages;

public class Catalog : PageModel
{
    ApplicationContext _context;
    public List<Product> Products { get; private set; } = new();

    public Catalog(ApplicationContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        Products = _context.Products.ToList();
    }
}