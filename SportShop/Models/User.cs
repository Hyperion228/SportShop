namespace SportShop.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int IsAdmin { get; set; } = 0;
    public int IsAutorize { get; set; } = 0;
}