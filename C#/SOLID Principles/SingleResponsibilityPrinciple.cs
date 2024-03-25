// Violates SRP
public class UserManager
{
    public void AddUser(string username)
    {
        // Add user to database
    }

    public void SendEmail(string emailContent)
    {
        // Send an email to the user
    }
}

// Follows SRP
public class User
{
    public void AddUser(string username)
    {
        // Add user to database
    }
}

public class EmailService
{
    public void SendEmail(string emailContent)
    {
        // Send an email
    }
}