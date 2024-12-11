using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DIP.Bad
{
    internal class Notification
    {
        private readonly EmailSender _emailSender;

        public Notification()
        {
            _emailSender = new EmailSender();
        }

        public void SendEmail(string message)
        {
            _emailSender.EmailMessage(message);
        }
    }
}
