using MVC.Entities;

namespace MVC.Persistence;

public class UserRepository
{
    private List<User> Users =
    [
        new User
        {
            Id = 1,
            Username = "Rune",
            Password = "Mojn",
            Email = "rpe@solita.dk"
        },

        new User
        {
            Id = 2,
            Username = "Youssef",
            Password = "mojnmojn",
            Email = "Email@youssef.dk"
        }
    ];
    
    public User GetUser(string username, string password)
    {
        return Users.First(x => x.Username == username && x.Password == password);
    }

    public User GetUserById(int id)
    {
        throw new NotImplementedException();
    }
}

// Model View Controller pattern
// Service Layer
// Repository
// Mapping Utility
// Use of DTOs

// UserMapper -> Repository Pattern og Service Layer Pattern