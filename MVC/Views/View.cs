using MVC.Controllers;
using MVC.DTO;

// View
Login();

// Single Responsibility Principle

// Separation of Concerns

// View                 <-> Controller <-> Services        -> UserMapper (Som både mapper til Dto og henter fra databasen)
//  -> Custom Logic                      -> Utility
//                                       -> Mapping


static void Login()
{
    var controller = new LoginController();

    var username = Console.ReadLine();
    var password = Console.ReadLine();

    var user = controller.Login(username, password);

    if (user != null)
    {
        SendToDashboard(user);
        return;
    }

    Login();
}

static void SendToDashboard(UserDTO userDto)
{
    Console.WriteLine($"Hello ${userDto.Email}");
}