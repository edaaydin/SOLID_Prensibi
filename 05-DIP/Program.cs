// See https://aka.ms/new-console-template for more information
using _05_DIP.Good;

Console.WriteLine("Hello, World!");

Notification notification = new Notification(new EmailSender());
notification.Send("");

Notification notification1 = new Notification(new SMSSender());
notification1.Send("");

Notification notification2 = new Notification(new PushNotification());
notification2.Send("");