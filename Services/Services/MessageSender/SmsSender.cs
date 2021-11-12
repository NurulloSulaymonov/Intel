using System;
using System.Diagnostics;

namespace Services.Services.MessageSender
{
    public class SmsSender:IMessageSender
    {
        public void Send(string message)
        {
            Debug.WriteLine($"Sending to Sms {message}");
        }

        public Guid GetId()
        {
            return Guid.NewGuid();
        }
    }
}