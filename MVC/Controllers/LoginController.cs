using MVC.DTO;
using MVC.Services;

namespace MVC.Controllers;

public class LoginController
{
    public UserDTO Login(string? username, string? password)
    {
        var loginService = new LoginService();

        return loginService.Login(username, password);
    }
}