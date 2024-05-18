using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportShop.Models;

namespace SportShop.Pages;

public class Login : PageModel
{
    ApplicationContext _context;
    public string UserHello { get; private set; } = "";
    public string Message { get; private set; } = "";

    public Login(ApplicationContext context)
    {
        _context = context;
    }

    public IActionResult OnPost(string userName, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
        if (user != null)
        {
            UserHello = $"Привет {user.Username}";
            Message = "Вы успешно вошли";
            return Page();
        }
        else
        {
            Message = "Введен неверный логин или пароль";
            return Page();
        }
    }
    public void OnGet()
    {
        Message = "Введите логин и пароль";
    }
}