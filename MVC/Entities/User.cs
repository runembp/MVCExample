namespace MVC.Entities;

public class User
{
    public int Id { get; set; } 
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    
    
    public string SecretInformation { get; set; } = "Secret 1";
    public string SecretAddress { get; set; } = "Secret 2";
}