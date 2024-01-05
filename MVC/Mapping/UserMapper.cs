using MVC.DTO;
using MVC.Entities;

namespace MVC.Mapping;

public class UserMapper
{
    public UserDTO MapUserToDto(User user)
    {
        var userDto = new UserDTO
        {
            Id = user.Id,
            Email = user.Email
        };

        return userDto;
    }
}