using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;

namespace SportShop.Pages;

public class IndexModel : PageModel
{
    ApplicationContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Product> Products { get; private set; } = new List<Product>();

    public IndexModel(ApplicationContext db)
    {
        _context = db;
    }
    
    public void OnGet()
    {
        Products = _context.Products.ToList();
    }
}