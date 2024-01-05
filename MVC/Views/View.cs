using MVC.Controllers;
using MVC.DTO;

// View
var username = Console.ReadLine();
var password = Console.ReadLine();

Login(username, password);

// Single Responsibility Principle

// Separation of Concerns

// View                 <-> Controller <-> Services        -> UserMapper (Som både mapper til Dto og henter fra databasen)
//  -> Custom Logic                      -> Utility
//                                       -> Mapping


static void Login(string username, string password)
{
    var controller = new LoginController();

    var user = controller.Login(username, password);

    if (user != null)
    {
        SendToDashboard(user);
        return;
    }

    // LoginAgain();
}

static void SendToDashboard(UserDTO userDto)
{
    Console.WriteLine($"Hello ${userDto.Email}");
}