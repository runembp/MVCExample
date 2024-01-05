namespace MVC.Services;

public class EmailService
{
    public bool ValidateEmail(string email)
    {
        // validate email. Contains @, contains .dk / .com / ends on .<country>

        return true;
    }
}