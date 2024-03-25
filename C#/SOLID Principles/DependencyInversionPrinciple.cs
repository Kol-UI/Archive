public interface IMessageSender
{
    void SendMessage(string message);
}

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        // Send email
    }
}

public class Notification
{
    private IMessageSender _messageSender;

    public Notification(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Send(string message)
    {
        _messageSender.SendMessage(message);
    }
}

public interface IMessageSender
{
    void SendMessage(string message);
}

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

public class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

public class Notification
{
    private IMessageSender _messageSender;

    public Notification(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Send(string message)
    {
        _messageSender.SendMessage(message);
    }
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        IMessageSender emailSender = new EmailSender();
        IMessageSender smsSender = new SmsSender();

        Notification emailNotification = new Notification(emailSender);
        emailNotification.Send("Hello via Email");

        Notification smsNotification = new Notification(smsSender);
        smsNotification.Send("Hello via SMS");
    }
}