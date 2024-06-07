using Microsoft.AspNetCore.Mvc;
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

    public IActionResult OnPost(int id)
    {
        BasketItems  = _context.BasketItems.ToList();
        var bask = _context.BasketItems.FirstOrDefault(b => b.Id == id);
        if (bask != null)
        {
            _context.BasketItems.Remove(bask);
            _context.SaveChanges();
            Message = "Товар удалён из корзины";
            return Page();
        }
        else
        {
            return Page();
        }
    }
    public void OnGet()
    {
        BasketItems = _context.BasketItems.ToList();
    }
}