using System;
using System.Diagnostics;

namespace Services.Services.MessageSender
{
    public class EmailSender:IMessageSender
    {
        private Guid id;
        
        public EmailSender()
        {
            id = Guid.NewGuid();
        }
        
        public void Send(string message)
        {
            Debug.WriteLine($"Sending to Email {message}");
        }


        public Guid GetId()
        {
            return id;
        }
    }
}