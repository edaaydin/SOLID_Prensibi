namespace _05_DIP.Good
{
    internal class Notification
    {
        private readonly IMessageSender _sender;
        public Notification(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Send(string message)
        {
            _sender.SendMessage(message);
        }
    }
}
