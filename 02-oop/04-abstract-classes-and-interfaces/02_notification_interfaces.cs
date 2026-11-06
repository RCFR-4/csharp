// Create a notification interface and use it to send email and SMS notifications.

EmailNotification e1 = new EmailNotification();
e1.EmailAddress = "cliente@email.com";

SmsNotification s1 = new SmsNotification();
s1.PhoneNumber = "11999999999";

INotification[] notifications = { e1, s1 };

foreach (INotification notification in notifications)
{
    notification.Send();
}

interface INotification
{
    void Send();
}

class EmailNotification : INotification
{
    public string EmailAddress { get; set; } = "";

    public void Send()
    {
        Console.WriteLine($"Message sent to email {EmailAddress}");
    }
}

class SmsNotification : INotification
{
    public string PhoneNumber { get; set; } = "";

    public void Send()
    {
        Console.WriteLine($"Message sent via SMS to number {PhoneNumber}");
    }
}
