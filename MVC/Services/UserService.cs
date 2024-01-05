using MVC.DTO;
using MVC.Mapping;
using MVC.Persistence;

namespace MVC.Services;

public class UserService
{
    private readonly UserRepository _userRepository;
    private readonly UserMapper _userMapper;

    public UserService(UserRepository userRepository, UserMapper userMapper)
    {
        _userRepository = userRepository;
        _userMapper = userMapper;
    }

    UserDTO GetUserById(int id)
    {
        var user = _userRepository.GetUserById(id);
        return _userMapper.MapUserToDto(user);
    }
}