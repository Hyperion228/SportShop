using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;

namespace SportShop.Pages;

public class Register : PageModel
{
    ApplicationContext _context;
    public string Message { get; set; } = "";

    public Register(ApplicationContext context)
    {
        _context = context;
    }

    public IActionResult OnPost(string userName, string password1, string password2)
    {
        if (password1 != password2)
        {
            Message = "Пароли не совпадают";
            return Page();
        }
        
        var user = new User
        {
            Username = userName,
            Password = password1,
        };

        _context.Users.Add(user);
        _context.SaveChanges();
        Message = "Пользователь успешно зарегистрирован";
        return Page();
    }
    public void OnGet()
    {
        Message = "Зарегистрируйте пользователя";
    }
}