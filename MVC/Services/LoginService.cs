using MVC.DTO;
using MVC.Mapping;
using MVC.Persistence;

namespace MVC.Services;

public class LoginService
{
    private readonly UserRepository _userRepository;
    private readonly UserMapper _userMapper;
    private readonly EmailService _emailService;
    
    public LoginService()
    {
        _userRepository = new UserRepository();
        _userMapper = new UserMapper();
        _emailService = new EmailService();
    }

    public UserDTO Login(string email, string password)
    {
        var isCorrectEmail = _emailService.ValidateEmail(email);
        
        if (!isCorrectEmail)
        {
            return null;
        }
        
        var user = _userRepository.GetUser(email, password);
        var userDto = _userMapper.MapUserToDto(user);

        return userDto;
    }

    public int CreateUser(string email, string password, string username)
    {
        // var isCorrectPassword = _passwordService.ValidatePassword(password);
        
        return 1;
    }
    
    
}